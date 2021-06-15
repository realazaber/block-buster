using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void Play()
    {
        print("Loaded first scene.");
        SceneManager.LoadScene("1");
    }

    public void Options()
    {
       
        print("Opened settings.");
    }

    public void Exit()
    {
        print("Quit game.");
        Application.Quit();
    }
}
