using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelCheck : MonoBehaviour
{
    public GameObject _topBlinker;
    public GameObject _bottomBlinker;

    public string _nextLevel;

    // Update is called once per frame
    void Update()
    {
        if (_topBlinker.activeSelf == true && _bottomBlinker.activeSelf == true && (Input.GetKey(KeyCode.Return)))
        {
            SceneManager.LoadScene(_nextLevel);
        }
    }
}
