using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractionObject : MonoBehaviour
{
    public enum InteractableType
    {
        nothing,
        info,
        pickup,
        dialogue
    }

    public InteractableType interType;

    public string infoMessage;
    private TMP_Text infoText;

    public string[] sentences;

    public void Start()
    {
        infoText = GameObject.Find("InfoText").GetComponent<TMP_Text>();
    }

    public void Nothing()
    {
        Debug.LogWarning("Object " + this.gameObject.name + " has no type set.");
    }

    public void Info()
    {
        StartCoroutine(ShowInfo(infoMessage, 2.5f));
    }

    public void Pickup()
    {
        this.gameObject.SetActive(false);
    }

    public void Dialogue()
    {

    }

    IEnumerator ShowInfo(string message, float delay)
    {
        infoText.text = message;
        yield return new WaitForSeconds(delay);
        infoText.text = null;
    }
}
