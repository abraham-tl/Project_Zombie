﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciudadano : MonoBehaviour
{
   public Struc_Ciudadano datos_ciudadano; // Se instancia una estructura  Struc Ciudadano
    
    void Start()
    {
        datos_ciudadano.edad = Random.Range(15, 101); //asigna edad aleatoria al ciudadano
        datos_ciudadano.nombre = (Ciudadano_Nombre)Random.Range(0, 20); //Asigana al ciudadano un nombre aleatorio desde un enum
        gameObject.tag = "Ciudadano";//Se tagea como ciudadano
    }

 }
