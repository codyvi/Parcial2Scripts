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
    public bool flag = false;

    
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

        if(currentAmo <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(3);
            
            return;
        }

        if(Input.GetButtonDown("Fire1"))
        {
            clone = Instantiate(bala, transform.position,transform.rotation);
            clone.velocity = transform.TransformDirection(0,0,-speed);
            currentAmo--;
            Destroy(clone.gameObject,1);
            // numBalas--;
        }
    }
  
}