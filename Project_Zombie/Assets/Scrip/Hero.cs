using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero {
    GameObject hero;//Variable para el GAmeObject de la clase

    //Constructor de la calse Heroe
    public Hero(Vector3 pos)
    {
        hero = GameObject.CreatePrimitive(PrimitiveType.Capsule);//se crea una primitiva en la variable Game Object
        hero.GetComponent<Renderer>().material.color = Color.black;//Se le asigna un color al GameObject
        hero.AddComponent(typeof(FPSMove));//Se le asigna la clase FPSMove al GameObject para el movimiento
        Camera.main.transform.localPosition = hero.transform.position;//se le asigna a la camara la misposicion del heroe
        Camera.main.transform.SetParent(hero.transform);//se hace la camara hija del heroe
        Camera.main.gameObject.AddComponent<FPSAim>();//se le agrega la la clase FPSAim a la camara para la rotacion    
    }
    //metodo para retornar el GameObject de la clase
    public GameObject Hero_
    {
        set
        {
            hero = value;
        }
        get
        {
            return hero;
        }
    }
}
