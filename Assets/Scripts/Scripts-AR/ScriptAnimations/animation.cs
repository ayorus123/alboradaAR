﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    Animation anim;
    public string nombreAnimacion;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1 || Input.GetMouseButtonDown(0))
        {
      
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
           // Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position)
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {                                   
                    anim.CrossFade(nombreAnimacion);
                }
                
            }
            
        }
    }
}
