using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject _player;
    public Rigidbody _playerRigidbody;

    public float _speed = 10;

    public float _jumpHeight = 350;
    public int _jumpCount = 0;

    //Keys
    public KeyCode _right;
    public GameObject _faceRightModel;

    public KeyCode _left;
    public GameObject _faceLeftModel;

    public KeyCode _jump;

    public KeyCode _bothJump;
    public GameObject _otherPlayer;
    public Rigidbody _otherPlayerRigidbody;
    public KeyCode _sprint;


    private void Start()
    {
        _faceRightModel.SetActive(true);
        _faceLeftModel.SetActive(false);
    }

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
            _faceRightModel.SetActive(true);
            _faceLeftModel.SetActive(false);
            _player.transform.position += transform.right * _speed * Time.deltaTime;
            print("Player move right");
            if (Input.GetKeyDown(_jump) && _jumpCount < 2)
            {
                _jumpCount++;
                _playerRigidbody.AddForce(transform.up * _jumpHeight);
                print("Player jump");
            }
        }
        else if (Input.GetKey(_left))
        {
            _faceRightModel.SetActive(false);
            _faceLeftModel.SetActive(true);
            _player.transform.position -= transform.right * _speed * Time.deltaTime;
            print("Player move left");
            if (Input.GetKeyDown(_jump) && _jumpCount < 2)
            {
                _jumpCount++;
                _playerRigidbody.AddForce(transform.up * _jumpHeight);
                print("Player jump");
            }
        }
        else if (Input.GetKeyDown(_jump) && _jumpCount < 2)
        {
            _jumpCount++;
            _playerRigidbody.AddForce(transform.up * _jumpHeight);
            print("Top player jump");
        }
        else if (Input.GetKeyDown(_bothJump) && _jumpCount < 2)
        {
            _jumpCount++;
            _playerRigidbody.AddForce(transform.up * _jumpHeight);
            _otherPlayerRigidbody.AddForce(transform.up * _jumpHeight);
            print("Both jump");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            _jumpCount = 0;
        }
    }
}
