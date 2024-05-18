using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float timeToDestroy = 5f;

    private void FixedUpdate()
    {
        timeToDestroy -= Time.fixedDeltaTime;
        if (timeToDestroy < 0)
        {
            Destroy(this.gameObject);
        }
    }
}
