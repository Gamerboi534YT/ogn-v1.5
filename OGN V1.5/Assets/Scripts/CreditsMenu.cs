using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsMenu : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }

}
