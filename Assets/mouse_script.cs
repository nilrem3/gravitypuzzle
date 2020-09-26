using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_script : MonoBehaviour
{
    public bool mouseMoves = true;
    public float mouseY;
    // Start is called before the first frame update
    void Start()
    {
        
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
    // Update is called once per frame
    void FixedUpdate()
    {


        if (mouseMoves)
        {
            Vector3 mousePos = Input.mousePosition;
            {
                mouseY = -mousePos.y + Screen.width / 4;

                transform.Rotate(mouseY / 500, 0.0f, 0.0f);
            }
        }
        
    }
}
