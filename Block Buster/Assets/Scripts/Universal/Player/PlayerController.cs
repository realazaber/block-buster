using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject _player;
    public Rigidbody _playerRigidbody;

    public float _speed = 10;
    public float _jumpHeight = 350;

    //Keys
    public KeyCode _right;
    public KeyCode _left;
    public KeyCode _jump;
    public KeyCode _bothJump;
    public KeyCode _sprint;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(_sprint))
        {
            _speed *= 2;
            print("Sprint speed " + _speed);
        }

        if (Input.GetKeyUp(_sprint))
        {
            _speed /= 2;
            print("Walk speed " + _speed);
        }

        if (Input.GetKey(_right))
        {
            
            _player.transform.position += transform.right * _speed * Time.deltaTime;
            print("Player move right");         
            if (Input.GetKeyDown(_jump))
            {
                _playerRigidbody.AddForce(transform.up * _jumpHeight);
                print("Player jump");
            }
        }
        else if (Input.GetKey(_left))
        {

            _player.transform.position -= transform.right * _speed * Time.deltaTime;
            print("Player move left");
            if (Input.GetKeyDown(_jump))
            {

                _playerRigidbody.AddForce(transform.up * _jumpHeight);
                print("Player jump");
            }
        }
        else if (Input.GetKeyDown(_jump))
        {

            _playerRigidbody.AddForce(transform.up * _jumpHeight);
            print("Top player jump");
        }


    }
}
