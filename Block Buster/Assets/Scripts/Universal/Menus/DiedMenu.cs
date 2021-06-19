using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiedMenu : MonoBehaviour
{
    public string _scene;

    public void Retry()
    {
        SceneManager.LoadScene(_scene);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
