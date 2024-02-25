using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public Text textToCheck; // Text component to check
    public string targetText; // Text to match for scene loading
    public string sceneToLoad; // Name of the scene to load

    void Update()
    {
        // Check if the text matches the target text
        if (textToCheck.text == targetText)
        {
            // Load the specified scene
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
