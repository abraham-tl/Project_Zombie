using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciudadano : MonoBehaviour
{

    //int edad;//Variable para la edad
    //string name;//variable para el nombre
    //GameObject ciudadano;

    void Start()
    {
        gameObject.tag = "Ciudadano";
    }
    //Constructor de la calse Ciudadano
    public Ciudadano(string n,Vector3 pos)
    {
        //edad = Random.Range(15, 101);//Asigna a la edad una aleatorio entre 15 y 101
        //name = n;
        //ciudadano = GameObject.CreatePrimitive(PrimitiveType.Cube); //se crea una primitiva en la variable Game Object
        //ciudadano.GetComponent<Renderer>().material.color = Color.gray; //Se le asigna un color al GameObject
        //ciudadano.transform.position = pos;//Se le asigna una posicion al GameObject
        //Debug.Log(Imprimir_Mensaje());//imprime la funcion Imprimir_mensaje
    }



 }
