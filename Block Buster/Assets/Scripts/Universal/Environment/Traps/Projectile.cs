using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float _speed;
    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        _rb.AddForce(transform.right * -1 * _speed * Time.deltaTime);
    }
}
