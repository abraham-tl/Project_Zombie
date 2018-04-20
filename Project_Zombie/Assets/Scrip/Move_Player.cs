using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Player : MonoBehaviour {
    public float speed;
    public bool invertedmouse;
    float mousex;
    float mousey;

    // Use this for initialization
    void Start () {
        speed = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed;
        }
       
        mousex = mousex + Input.GetAxis("Mouse X");
        transform.eulerAngles = new Vector3(0, mousex, 0);
        
    }
}
