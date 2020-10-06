using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity_object_maker : MonoBehaviour
{
    public GameObject gravitymachine;
    public GameObject thisObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha2))
        {
            transform.position += transform.forward / 5;
        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            transform.position += -transform.forward / 5;
        }
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(gravitymachine, transform.position, transform.rotation);
        }
    }
}
