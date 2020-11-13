using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    public AudioSource fuente;
    public AudioClip clips;
    private void OnMouseDown()
    {
        
        if (!GameControl.youWin)
        {
            transform.Rotate(0f, 0f, 90f);
        }
        
    }
    private void OnMouseUp()
    {

        if (GameControl.youWin)
        {
            fuente.clip = clips;
            fuente.Play();
                
        }
    }
}
