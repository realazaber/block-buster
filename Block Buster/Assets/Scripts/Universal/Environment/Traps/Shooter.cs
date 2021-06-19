using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public bool _isRunning = true;
    public int _seconds;

    public Transform _launchPoint;
    public Rigidbody _projectile;

    public int _speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_isRunning == true)
        {
            StartCoroutine(Wait());
        }
    }

    public IEnumerator Wait()
    {
        _isRunning = false;
        yield return new WaitForSeconds(_seconds);
        LaunchProjectile();
        _isRunning = true;
    }

    void LaunchProjectile()
    {
        var projectile = Instantiate(_projectile, _launchPoint.position, _launchPoint.rotation);
        
    }
}
