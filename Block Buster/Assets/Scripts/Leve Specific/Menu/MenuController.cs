using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public string _scene;

    public GameObject _world;
    public GameObject _menu;

    public bool _isLevel = true;

    private void Update()
    {
        if (_isLevel && Input.GetKey(KeyCode.Escape))
        {
            _world.SetActive(false);
            _menu.SetActive(true);
        }
        
        if (_isLevel && Input.GetKey(KeyCode.P))
        {
            _world.SetActive(true);
            _menu.SetActive(false);
        }
    }

    public void Play()
    {
        print("Loaded scene " + _scene);
        SceneManager.LoadScene(_scene);
    }

    public void Resume()
    {
        _world.SetActive(true);
        _menu.SetActive(false);
    }

    public void Options()
    {
       
        print("Opened settings.");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Exit()
    {
        print("Quit game.");
        Application.Quit();
    }
}
