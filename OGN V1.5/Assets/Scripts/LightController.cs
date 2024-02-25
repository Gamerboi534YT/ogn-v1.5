using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light lightToControl;
    public float onDuration = 2f; // Duration the light stays on
    public float offDuration = 1f; // Duration the light stays off
    
    private bool isLightOn = false;
    private float timer = 0f;

    void Start()
    {
        // Ensure the light is initially off
        lightToControl.enabled = false;
    }

    void Update()
    {
        timer += Time.deltaTime;

        // Check if it's time to switch the light
        if (isLightOn && timer >= onDuration)
        {
            SwitchLightOff();
        }
        else if (!isLightOn && timer >= offDuration)
        {
            SwitchLightOn();
        }
    }

    void SwitchLightOn()
    {
        lightToControl.enabled = true;
        isLightOn = true;
        timer = 0f;
    }

    void SwitchLightOff()
    {
        lightToControl.enabled = false;
        isLightOn = false;
        timer = 0f;
    }
}
