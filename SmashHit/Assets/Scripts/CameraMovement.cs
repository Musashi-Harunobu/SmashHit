using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float cameraSpeed = 10;


    private void FixedUpdate()
    {
        transform.position += Vector3.forward * cameraSpeed * Time.fixedDeltaTime;
    }
}
