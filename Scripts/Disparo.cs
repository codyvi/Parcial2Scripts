using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disparo : MonoBehaviour
{
    public Rigidbody bala;
    public float speed;
    // public static string message;
    // public static int numBalas;
    Rigidbody clone;

    void Start (){
    	// txt.text = "Balas: ";
    	// numBalas = 60;
    	// msg.text = "";
    	// message = "";
    }
    // Update is called once per frame
    void Update()
    {
    	// txt.text = "Balas: " + numBalas;
    	// msg.text = message;

        if(Input.GetButton("Fire1"))
        {
            clone = Instantiate(bala, transform.position,transform.rotation);
            clone.velocity = transform.TransformDirection(0,0,-speed);
            Destroy(clone.gameObject,1);
            // numBalas--;
        }
    }
}