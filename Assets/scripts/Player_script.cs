using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography;
using UnityEngine;

public class Player_script : MonoBehaviour
{
    public Rigidbody player;
    public GameObject playerCamera;
    public float playerSpeed = 200f;

    float mouseX;
    float mouseY;
    float newMouseX;
    float newMouseY;
    float mouseDeltaY;
    float mouseDeltaX;
    public float jumpSpeed = 200f;
    
    public bool mouseMoves = true;
    void Start()
    {
        
        
        //Fetch the Rigidbody from the GameObject with this script attached
        player = GetComponent<Rigidbody>();
        
    }
    void Update() { 
        if (Input.GetKeyDown("q")) { 
            if (mouseMoves) { 
                mouseMoves = false;
                Debug.Log(mouseMoves);
            }
            else { 
                mouseMoves = true;
                Debug.Log(mouseMoves);
            }

        }
        
    }

    void FixedUpdate() {

        if (mouseMoves)
        {
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = false;
            float mousePosX = Input.GetAxis("Mouse X");
            float mousePosY = Input.GetAxis("Mouse Y");

            mouseX = mousePosX;
            mouseY = mousePosY;
            transform.Rotate(0.0f, mouseX, 0.0f);
            playerCamera.transform.Rotate(-mouseY, 0.0f, 0.0f);
        }

        if (Input.GetKey("w"))
        {

            player.AddForce(transform.forward * playerSpeed);
        }

        if (Input.GetKey("s"))
        {

            player.AddForce(-transform.forward * playerSpeed);
        }


        if (Input.GetKey("a"))
        {

            player.AddForce(-transform.right * playerSpeed);
        }

        if (Input.GetKey("d"))
        {

            player.AddForce(transform.right * playerSpeed);
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
            
        }


        


    }

    void OnTriggerStay(Collider collision)
    {
        if(!collision.isTrigger)
            {
            if (Input.GetKey("space"))
            {

                player.AddForce(transform.up * jumpSpeed);
            }
        }
    }
    
}
