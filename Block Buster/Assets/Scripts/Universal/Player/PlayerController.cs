using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject _topPlayer;
    public GameObject _bottomPlayer;
    public float _speed;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            
            _topPlayer.transform.position = transform.forward / _speed;
        }
    }
}
