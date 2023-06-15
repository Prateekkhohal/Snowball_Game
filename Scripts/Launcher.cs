using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public Transform launchpoint;
    public GameObject projectile;

    public float launchVelocity = 10f;

    public float sensitivity = 100f;


    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;

        transform.Rotate(Vector3.up * mouseX);

        if (Input.GetButtonDown("Fire1"))
        {
            var _projectile = Instantiate(projectile, launchpoint.position, launchpoint.rotation);
            _projectile.GetComponent<Rigidbody>().velocity = launchpoint.up * launchVelocity;
        }
    }
} 
