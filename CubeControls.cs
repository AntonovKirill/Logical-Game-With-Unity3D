using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControls : MonoBehaviour {

    void Start () {
        
    }
    void Update()
    {
        float speed = 60f;
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        }
    }
   
}
