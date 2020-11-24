using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Camera cam;

    void Start()
    {
        cam = GetComponentInChildren<Camera>();
    }

    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
           cam.fieldOfView = cam.fieldOfView + Input.GetAxis("Mouse ScrollWheel") * 10;
           transform.Rotate(0, Input.GetAxis("Mouse X") * 5, 0);
            cam.transform.Rotate(-Input.GetAxis("Mouse Y"), 0, 0);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + Input.GetAxis("Mouse ScrollWheel"), transform.position.z);
        }

    }
}
