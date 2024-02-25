using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text textToControl;
    public string[] textOptions; // Array of text options to cycle through
    public float changeInterval = 2f; // Time interval for changing text

    private int currentIndex = 0;
    private float timer = 0f;

    void Start()
    {
        // Initialize text with the first option
        if (textOptions.Length > 0)
            textToControl.text = textOptions[currentIndex];
    }

    void Update()
    {
        timer += Time.deltaTime;

        // Check if it's time to change the text
        if (timer >= changeInterval)
        {
            ChangeText();
        }
    }

    void ChangeText()
    {
        // Increment index and reset if out of bounds
        currentIndex = (currentIndex + 1) % textOptions.Length;
        textToControl.text = textOptions[currentIndex];
        timer = 0f;
    }
}
