using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject _topPlayer;
    public Rigidbody _topPlayerRB;

    public GameObject _bottomPlayer;
    public Rigidbody _bottomPlayerRB;

    public float _speed;
    public float _jumpHeight;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            _speed *= 2;
            print("Sprint speed " + _speed);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            _speed /= 2;
            print("Walk speed " + _speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            
            _topPlayer.transform.position += transform.right * _speed * Time.deltaTime;
            print("Top player move right");
            if (Input.GetKeyDown(KeyCode.W))
            {

                _topPlayerRB.AddForce(transform.up * _jumpHeight);
                print("Top player jump");
            }
        }
        else if (Input.GetKey(KeyCode.A))
        {

            _topPlayer.transform.position -= transform.right * _speed * Time.deltaTime;
            print("Top player move left");
            if (Input.GetKeyDown(KeyCode.W))
            {

                _topPlayerRB.AddForce(transform.up * _jumpHeight);
                print("Top player jump");
            }
        }
  

    }
}
