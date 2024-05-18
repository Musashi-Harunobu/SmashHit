using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DistructionEffects : MonoBehaviour
{
    [SerializeField] private GameObject[] fragments;
    [SerializeField] private int bonusBalls = 0;
    
    public UnityEvent OnDestruction;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Ball>())
        {
            if (bonusBalls > 0)
            {
                GameManager.TakeBalls(bonusBalls);
            }

            if (fragments != null)
            {
                for (int i = 0; i < fragments.Length; i++)
                {
                    fragments[i].SetActive(true);
                    fragments[i].GetComponent<MeshRenderer>().enabled = true;
                    if (fragments[i].GetComponent<Rigidbody>())
                    {
                        fragments[i].GetComponent<Rigidbody>().useGravity = true;
                        fragments[i].GetComponent<Rigidbody>().isKinematic = false;
                    }
                }
                OnDestruction.Invoke();
                this.gameObject.SetActive(false);
            }
        }
        // if (other.CompareTag("ConnectedGlass"))
        // {
        //     other.transform.parent = other.transform.root;
        //
        //     if (other.gameObject.GetComponent<Rigidbody>() == null)
        //     {
        //         other.gameObject.AddComponent<Rigidbody>();
        //     }
        // }
    }
}
