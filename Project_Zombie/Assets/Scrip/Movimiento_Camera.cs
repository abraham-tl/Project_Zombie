using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Camera : MonoBehaviour {
    bool invertedmouse;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (invertedmouse)
        {
            //mousey = mousey + Input.GetAxis("Mouse Y");
        }
        else
        {
            //mousey = mousey - Input.GetAxis("Mouse Y");
        }
    }
}
