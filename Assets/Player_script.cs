using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_script : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public GameObject playerCamera;
    public float m_Speed = 20f;
    float mouseX;
    float mouseY;
    float lateMouseX;
    float lateMouseY;
    float changeInMouseY;
    float changeInMouseX;
    public float jumpSpeed = 100;
    
    public bool mouseMoves = true;
    void Start()
    {
        
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            if (mouseMoves)
            {
                mouseMoves = false;
                Debug.Log(mouseMoves);
            }
            else
            {
                mouseMoves = true;
                Debug.Log(mouseMoves);
            }

        }
    }

    void FixedUpdate()
    {

        if (mouseMoves)
        {

            Vector3 mousePos = Input.mousePosition;
            {
                mouseX = mousePos.x;
                mouseY = mousePos.y;
                changeInMouseX = 0 - (lateMouseX - mouseX);
                changeInMouseY = lateMouseY - mouseY;
                Debug.Log(changeInMouseX);
                Debug.Log(changeInMouseY);
                transform.Rotate(0.0f, changeInMouseX / 5, 0.0f);
                playerCamera.transform.Rotate(changeInMouseY / 5, 0.0f, 0.0f);

            }
        }


        
        if (Input.GetKey("w"))
        {

            m_Rigidbody.AddForce(transform.forward * m_Speed);
        }

        if (Input.GetKey("s"))
        {

            m_Rigidbody.AddForce(-transform.forward * m_Speed);
        }


        if (Input.GetKey("a"))
        {

            m_Rigidbody.AddForce(-transform.right * m_Speed);
        }

        if (Input.GetKey("d"))
        {

            m_Rigidbody.AddForce(transform.right * m_Speed);
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

                m_Rigidbody.AddForce(transform.up * jumpSpeed);
            }
        }
    }
    void LateUpdate()
    {

        lateMouseX = mouseX;
        lateMouseY = mouseY;
        
    }
}
