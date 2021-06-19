using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float _turnSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, _turnSpeed * Time.deltaTime, 0);
    }
}
