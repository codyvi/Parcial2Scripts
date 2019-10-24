using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    public Text txt;


    public static int crash;


    // Start is called before the first frame update
    void Start()
    {
        txt.text = "Vidas: ";
        crash = 3;
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Vidas: " + crash;
    }
}
