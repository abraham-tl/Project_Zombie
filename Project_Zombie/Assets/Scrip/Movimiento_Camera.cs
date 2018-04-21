using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Camera : MonoBehaviour {
    public Move_Player _rotations;
    float mousex;
    float mousey;
    bool invertedmouse;
    // Use this for initialization
    void Start () {
        transform.eulerAngles = new Vector3(30, 0, 0);
        //SE RELACIONA LA CLASE FPSMove CON FPSaim
        _rotations = FindObjectOfType<Move_Player>();
    }
	
	// Update is called once per frame
	void Update () {
        if (invertedmouse)
        {
            mousey = mousey + Input.GetAxis("Mouse Y");
        }
        else
        {
            mousey = mousey - Input.GetAxis("Mouse Y");
        }
        mousex = mousex + Input.GetAxis("Mouse Y");
        _rotations(mousex);
        
    }
}
