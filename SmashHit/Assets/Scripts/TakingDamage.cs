using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TakingDamage : MonoBehaviour
{
    private UnityEvent OnDamage;

    [SerializeField] private string[] dangerousTags;

    private void OnTriggerEnter(Collider other)
    {
        for(int i = 0; i < dangerousTags.Length; i++)
        {
            if (other.CompareTag(dangerousTags[i]))
            {
                GameManager.TakeDamage();
 
                OnDamage.Invoke();
            }
        }
    }
}
