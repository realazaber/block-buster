using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectOnTouch : MonoBehaviour
{
    public string _tag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == _tag)
        {
            Destroy(other.gameObject);
        }
    }
}
