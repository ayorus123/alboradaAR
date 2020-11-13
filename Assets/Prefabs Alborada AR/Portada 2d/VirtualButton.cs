using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using System;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbBtnObj;
    public Animator animUtiles;

    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("VButton");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        animUtiles.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        animUtiles.SetTrigger("playAnim");
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        animUtiles.Play("none");
        Debug.Log("Button released");
    }
}
