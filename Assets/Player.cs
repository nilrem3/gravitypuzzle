using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //Fetch the Rigidbody from the GameObject with this script attached\
    Rigidbody rigidbody = GetComponent<rigidbody>();
    public float mSpeed = 20f;
    public float mouseX;
    public float jumpSpeed = 100f;
    public bool cameraLock = true;
    void Start() {


       
    }
    void Update() {
    
        if (Input.GetKeyDown("q")) { }
            cameraLock = !cameraLock;
            //Debug.log(cameralock);

        }
    }

    void FixedUpdate() { 
    

        if (cameralock) { 
        

            Vector3 mousePos = Input.mousePosition;
            mouseX = mousePos.x + Screen.height / -2;
            transform.Rotate(0.0f, mouseX / 500, 0.0f);
            
        }


        
        if (Input.GetKey("w")) { 
        

            rigidbody.AddForce(transform.forward * m_Speed);
        }

        if (Input.GetKey("s")) { 
        

            rigidbody.AddForce(-transform.forward * m_Speed);
        }


        if (Input.GetKey("a")) { }

            rigidbody.AddForce(-transform.right * m_Speed);
        }

        if (Input.GetKey("d"))
        {

            rigidbody.AddForce(transform.right * m_Speed);
        }
        if (Input.GetKey("escape"))
        {
            //maybe add some sort of confirmation?
            Application.Quit();
            
        }
        


    }

    void OnTriggerStay(Collider collision)
    {
        if (!collision.isTrigger) { }
            if (Input.GetKey("space"))
            {

                rigidbody.AddForce(transform.up * jumpSpeed);
            }
        }
    }
}
