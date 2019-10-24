using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Disparo : MonoBehaviour
{
    public Rigidbody bala;
    public float speed;
    public int maxAmmo = 10;
    private int currentAmo;
    public AudioSource audioData;
    // public int puntos = 0;
    // public int count = 0;

    
    Rigidbody clone;

    void Start ()
    {
        currentAmo = maxAmmo;
    }
    // Update is called once per frame
    void Update()
    {
    	// txt.text = "Balas: " + numBalas;
    	// msg.text = message;

        //Condición para perder 
        if(currentAmo <= 0 || Vidas.crash == 0)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(3);
            
            return;
        }

        //Condición para ganar
        if(Puntos.crash == 25)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(4);
        }

        if(Input.GetButtonDown("Fire1"))
        {
            audioData.Play();
            clone = Instantiate(bala, transform.position,transform.rotation);
            clone.velocity = transform.TransformDirection(0,0,-speed);
            currentAmo--;
            Destroy(clone.gameObject,1);
        }
    }

    void OnCollisionEnter (Collision col)
    {
      if(col.gameObject.name=="Oxigeno")
      {
          Puntos.crash += 5;
      }
      if (col.gameObject.name=="Hierro")
      {
          Puntos.crash += 5;
      }
      if (col.gameObject.name=="Cobre")
      {
          Puntos.crash += 5;
      }
      if (col.gameObject.name=="Sodio")
      {
          Puntos.crash += 5;
      }
      if (col.gameObject.name=="Fosforo")
      {
          Puntos.crash += 5;
      }
      if(col.gameObject.name=="F1")
      {
          Vidas.crash--;
      }
      if(col.gameObject.name=="F2")
      {
          Vidas.crash--;
      }
      if(col.gameObject.name=="F3")
      {
          Vidas.crash--;
      }
      if(col.gameObject.name=="F4")
      {
          Vidas.crash--;
      }
      if(col.gameObject.name=="F5")
      {
          Vidas.crash--;
      }
    }
  
}