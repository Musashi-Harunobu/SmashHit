using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float cameraSpeed = 10;

    public UnityEvent OnMoveBreak;
    
    private void Awake()
    {
        GameManager.OnLoss.AddListener(BreakMovement);
    }
    private void FixedUpdate()
    {
        transform.position += Vector3.forward * cameraSpeed * Time.fixedDeltaTime;
    }
    public void BreakMovement()
    {
        cameraSpeed = 0;
        OnMoveBreak.Invoke();
    }
}
