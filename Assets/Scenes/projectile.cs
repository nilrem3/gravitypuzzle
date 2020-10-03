using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public Rigidbody a_projectile;
    public float speed = 15;
    public bool mouseNeedsToBeHeld = true;
    

    void Update()
    {
        if (mouseNeedsToBeHeld == true)
        {
            if (Input.GetMouseButton(0))
            {
                Rigidbody p = Instantiate(a_projectile, transform.position, transform.rotation);
                p.velocity = transform.forward * speed;
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                Rigidbody p = Instantiate(a_projectile, transform.position, transform.rotation);
                p.velocity = transform.forward * speed;
            }
        }
    }

}
