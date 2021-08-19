using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkDeath : MonoBehaviour
{
    public GameObject _topPlayer;
    public GameObject _bottomPlayer;

    public GameObject _youDiedMenu;
    public GameObject _topPlayerDied;
    public GameObject _bottomPlayerDied;

    public GameObject _world;


    private void Start()
    {
        _youDiedMenu.SetActive(false);
        _topPlayerDied.SetActive(false);
        _bottomPlayerDied.SetActive(false);

    }   

    private void Update()
    {
        if (_topPlayer.activeSelf == false)
        {
            print("Blue died");
            _world.SetActive(false);
            _youDiedMenu.SetActive(true);
            _topPlayerDied.SetActive(true);     
        }

        if (_bottomPlayer.activeSelf == false)
        {
            print("Red died");
            _world.SetActive(false);
            _youDiedMenu.SetActive(true);
            _bottomPlayerDied.SetActive(true);
        }
    }
}