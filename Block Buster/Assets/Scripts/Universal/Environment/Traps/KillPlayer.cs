using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer: MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SetActive(false);
        }
    }
}
