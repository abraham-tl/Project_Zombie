using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero {
    GameObject hero;//Variable para el GAmeObject de la clase

    public Hero(Vector3 pos)
    {
        
       
        hero = GameObject.CreatePrimitive(PrimitiveType.Capsule);//se crea una primitiva en la variable Game Object
        hero.GetComponent<Renderer>().material.color = Color.black;//Se le asigna un color al GameObject
        hero.AddComponent(typeof(Move_Player));//Se le asigna la clase Moviento_Player al GameObject 
                                               //hero.AddComponent<Movimiento_Camera>();
                                               /*      hero.AddComponent<Camera>();*///Se le asigna una camara al GameObject
                                                                                     //hero.transform.position = pos;//Se le asigna una posicion al GameObject

        Camera.main.transform.localPosition = hero.transform.position; ;
        //Camera.main.transform.SetParent (hero.transform );
        Camera.main.gameObject.AddComponent<Movimiento_Camera>();
        //GameObject cam = new GameObject();
        //cam.AddComponent<Camera>();
        //cam.AddComponent<Movimiento_Camera>();
        //cam.transform.SetParent(hero.transform);
        //cam.transform.position = pos;
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
