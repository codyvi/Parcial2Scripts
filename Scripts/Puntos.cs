﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    public Text txt;


    public static int crash;


    // Start is called before the first frame update
    void Start()
    {
        Disparo.yalediobro = 0;
        txt.text = "Puntos: ";
        crash = 0;
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Puntos: " + crash;
    }
}
