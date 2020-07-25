using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIVisible : MonoBehaviour
{

    public GameObject icon;

    void Start()
    {
        //icon = GetComponent<Icon>();
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            icon.layer = LayerMask.NameToLayer("UI");
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            icon.layer = LayerMask.NameToLayer("Invisible");
        }

    }
}
