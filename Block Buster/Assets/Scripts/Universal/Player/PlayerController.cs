using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject _player;
    public Rigidbody _playerRigidbody;

    public float _speed;

    public float _jumpHeight = 400;
    public int _jumpCount = 0;
    public int _maxJumps = 1;

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
            _speed *= 1.5f;
            print("Sprint speed " + _speed);
        }

        if (Input.GetKeyUp(_sprint))
        {
            _speed /= 1.5f;
            print("Walk speed " + _speed);
        }

        if (Input.GetKey(_right))
        {
            _faceRightModel.SetActive(true);
            _faceLeftModel.SetActive(false);
            _playerRigidbody.AddForce(transform.right * _speed);
            print("Player move right");
            if (Input.GetKeyDown(_jump) && _jumpCount < _maxJumps)
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
            _playerRigidbody.AddForce(transform.right * _speed * -1);
            print("Player move left");
            if (Input.GetKeyDown(_jump) && _jumpCount < _maxJumps)
            {
                _jumpCount++;
                _playerRigidbody.AddForce(transform.up * _jumpHeight);
                print("Player jump");
            }
        }
        else if (Input.GetKeyDown(_jump) && _jumpCount < _maxJumps)
        {
            _jumpCount++;
            _playerRigidbody.AddForce(transform.up * _jumpHeight);
            print("Top player jump");
        }
        else if (Input.GetKeyDown(_bothJump) && _jumpCount < _maxJumps)
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
            print("Touched the ground");
            _jumpCount = 0;
        }

        if (other.gameObject.tag == "PowerUpSpeed")
        {
            print("Speed power up");
            _speed *= 2;
        }

        if (other.gameObject.tag == "PowerUpDoubleJump")
        {
            print("Can double jump");
            _maxJumps = 2;
        }
    }
}
