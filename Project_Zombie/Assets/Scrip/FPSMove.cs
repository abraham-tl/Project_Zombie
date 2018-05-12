﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMove : MonoBehaviour {
    public float speed;
   
    float mousex;
    Vector3 rotation;

    void Start ()
    {
        speed = Random.Range(1.0f, 2.0f);
    }
     //DESPLAZA EL OBJETO EN EL PLANO SEGUN LA TECLA QUE SE PRESIONE (ADELANTE ATRAS Y ALOS LADOS)
	void Update () {
		if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed*Time.deltaTime ;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }

    }
    //ROTA EL OBJETO DESDE 
    public void Rotations_(float rotations)
    {
        transform.eulerAngles = new Vector3 (0, rotations,0);
    }
}