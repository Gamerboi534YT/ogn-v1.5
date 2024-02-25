using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BareEndoJumpscare : MonoBehaviour
{
    AudioSource _audio;
    private void Awake()
    {
        _audio= GetComponent<AudioSource>();
    }
    private void BareEndoJumpscareHandlerMethod()
    {
        MainMenuManager.Jumpscare();
    }
    void EndoSoundHandler()
    {
        _audio.Play();
    }
}
