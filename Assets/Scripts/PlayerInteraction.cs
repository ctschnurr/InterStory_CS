using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject currentInterObj= null;
    public InteractionObject currentInterObjScript = null;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("InterObject") == true)
        {
            currentInterObj = other.gameObject;
            currentInterObjscript = currentInterObj.GetComponent<InteractionObject>();
        }
    }
}
