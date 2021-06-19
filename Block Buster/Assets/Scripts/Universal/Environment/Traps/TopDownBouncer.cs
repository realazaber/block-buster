using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownBouncer : MonoBehaviour
{
    public float _speed;
    private Rigidbody _rb;

    private void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + transform.up * _speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bounce")
        {
            print("Bounced");
            _speed *= -1;
        }
    }
}
