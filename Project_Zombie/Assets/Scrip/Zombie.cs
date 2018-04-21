using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie  {
    
    Color color_zombie;//Variable para el color que se le asigna al GameObject
    string name_color_zombie;//Variable para el nombre del color que se le asigna al GameObject
    GameObject zombie;//Variable para el GAmeObject de la clase

    public Zombie(Color col,string color,Vector3 pos)
    {
        color_zombie = col;
        name_color_zombie = color;
        zombie = GameObject.CreatePrimitive(PrimitiveType.Cube); //se crea una primitiva en la variable Game Object
        zombie.GetComponent<Renderer>().material.color = color_zombie; //Se le asigna un color al GameObject
        zombie.transform.position = pos;//Se le asigna una posicion al GameObject
        Debug .Log(Imprimir_Mensaje());//imprime la funcion Imprimir_mensaje
    }

    string Imprimir_Mensaje()
    {
        return "SOY UN ZOMBIE DE COLOR "+ name_color_zombie;//retorna el texto y el color
    }

    public GameObject Zombie_//Retorna el objeto de la clase
    {
        set
        {
            zombie = value;
        }
        get
        {
            return zombie;
        }
    }
}
