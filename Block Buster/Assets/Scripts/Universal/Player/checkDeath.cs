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

    private void Update()
    {
        if (_topPlayer.activeSelf == false)
        {
            _youDiedMenu.SetActive(true);
            _topPlayerDied.SetActive(true);
        }

        if (_bottomPlayer.activeSelf == false)
        {
            _youDiedMenu.SetActive(true);
            _bottomPlayerDied.SetActive(true);
        }
    }

}
