using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesplegarAudio : MonoBehaviour
{
    public AudioSource fuente;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        fuente.clip = clip;
    }

    void Update() {
        if (Input.touchCount == 1 || Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
           // Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position)
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    fuente.Play();
                }
            }
           
        }       
    }
}
