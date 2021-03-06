﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    
    [SerializeField]
    private Transform[] pictures;

    [SerializeField]
    private GameObject winText;

    public static bool youWin;
    // Start is called before the first frame update
    void Start()
    {
        float[] posiciones = new float[4];
        posiciones[0] = 90f;
        posiciones[1] = 270f;
        posiciones[2] = 0f;
        pictures[0].Rotate(0f, 0f, posiciones[UnityEngine.Random.Range(0, 3)]);
        pictures[1].Rotate(0f, 0f, posiciones[UnityEngine.Random.Range(0, 3)]);
        pictures[2].Rotate(0f, 0f, posiciones[UnityEngine.Random.Range(0, 3)]);
        pictures[3].Rotate(0f, 0f, posiciones[UnityEngine.Random.Range(0, 3)]);
        pictures[4].Rotate(0f, 0f, posiciones[UnityEngine.Random.Range(0, 3)]);
        pictures[5].Rotate(0f, 0f, posiciones[UnityEngine.Random.Range(0, 3)]);
        winText.SetActive(false);
        youWin = false;


    }

    // Update is called once per frame
    void Update()
    {
        if (pictures[0].rotation.z == 0 &&
            pictures[1].rotation.z == 0 &&
            pictures[2].rotation.z == 0 &&
            pictures[3].rotation.z == 0 &&
            pictures[4].rotation.z == 0 &&
            pictures[5].rotation.z == 0 
           
            )
        {
           
            youWin = true;
            winText.SetActive(true);
            Invoke("IrMenu", 4f);

        }
        
    }
    void IrMenu()
    {
        SceneManager.LoadScene("juegoRompecabezas");
    }
}
