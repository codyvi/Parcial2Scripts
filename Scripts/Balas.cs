using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balas : MonoBehaviour
{
    public Text txt;


    public static int crash;


    // Start is called before the first frame update
    void Start()
    {
        txt.text = "Balas: ";
        crash = 10;
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Balas: " + crash;
    }
}
