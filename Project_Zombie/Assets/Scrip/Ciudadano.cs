using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciudadano : MonoBehaviour
{

    //int edad;//Variable para la edad
    //string name;//variable para el nombre
    //GameObject ciudadano;
    public Struc_Ciudadano datos_ciudadano;
   
    
    void Start()
    {
        datos_ciudadano.edad = Random.Range(15, 101);
        datos_ciudadano.nombre = (Ciudadano_Nombre)Random.Range(0, 20);
        gameObject.tag = "Ciudadano";
    }

 }
