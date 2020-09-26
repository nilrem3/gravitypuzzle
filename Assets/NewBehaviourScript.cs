using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Speed = 20f;
    public float mouseX;
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
                mouseX = mousePos.x + Screen.height / -2;

                transform.Rotate(0.0f, mouseX / 500, 0.0f);
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
}
