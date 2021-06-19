using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour
{
    public GameObject _blinker;

    public void Start()
    {
        _blinker.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            print("Player entered exit: TURN ON BLINKER");
            _blinker.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("Player left exit: TURN OFF BLINKER");
            _blinker.SetActive(false);
        }
    }
}
