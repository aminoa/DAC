using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogRead : MonoBehaviour, IInteractable
{
    private void Start()
    {

    }


    public string GetDescription()
    {
        return "Change to random color?";
    }

    public void Interact()
    {
        Debug.Log("Works");
    }
}
