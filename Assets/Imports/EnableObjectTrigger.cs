﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[AddComponentMenu("AIE Scripts/GameDesignFoundations/Enable Object Trigger")]
public class EnableObjectTrigger : MonoBehaviour
{

    public List<string> TriggerTags = new List<string>();
    public GameObject ObjectToEnable;
    public bool DisableOnTriggerExit = true;
    public bool TriggersOnceOnly = false;
    private bool HasAlreadyBeenTriggered = false;

    void OnTriggerEnter(Collider collided)
    {
        if (TriggerTags.Count > 0 && !HasAlreadyBeenTriggered)
        {
            foreach (string TAG in TriggerTags)
            {
                if (collided.gameObject.CompareTag(TAG))
                {
                    if (ObjectToEnable != null)
                    {
                        ObjectToEnable.SetActive(true);
                    }
                    if (ObjectToEnable == null)
                    {
                        Debug.Log("Trigger activated but no GameObject specified to Enable");
                    }
                    if (TriggersOnceOnly)
                    {
                        HasAlreadyBeenTriggered = true;
                    }
                }
            }
        }
    }

    void OnTriggerExit(Collider collided)
    {
        if (TriggerTags.Count > 0 && !DisableOnTriggerExit)
        {
            foreach (string TAG in TriggerTags)
            {
                if (collided.gameObject.CompareTag(TAG))
                {
                    if (ObjectToEnable != null)
                    {
                        ObjectToEnable.SetActive(false);
                    }
                    if (ObjectToEnable == null)
                    {
                        Debug.Log("Trigger activated but no GameObject specified to Disable");
                    }
                }
            }
        }
    }

}
