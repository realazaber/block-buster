using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDeactivate : MonoBehaviour
{
    public GameObject _objectToDeactivate;
    public bool _touchingButton = false;

    // Start is called before the first frame update
    void Start()
    {
        _objectToDeactivate.SetActive(true);
    }

    private void Update()
    {
        if (_touchingButton == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                print("Button pressed");
                _objectToDeactivate.SetActive(false);
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("Player touching button");
            _touchingButton = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("Player NOT touching button");
            _touchingButton = false;
        }
    }

}
