using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie  {
    public int tipo;
    public Color col;
    public string name;
    public int edad;
    GameObject objeto;
    //public int hitpoints;
   
    
    public Zombie(int tipo,Color col,string n,int edad_)
    {
        edad = edad_; 
        if (tipo == 0)
        {
            objeto = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        }
        else if(tipo == 1)
        {
            objeto = GameObject.CreatePrimitive(PrimitiveType.Cube);    
            name = "SOY UN ZOMBIE DE COLOR :";
        }
        else if (tipo == 2)
        {
            objeto = GameObject.CreatePrimitive(PrimitiveType.Cube );
            name = "HOLA SOY  "+ n + " Y TENGO "+ edad +" AÑOS";
        }
        Vector3 pos = new Vector3();
        pos.x = Random.Range(-10,10);
        pos.y = 0f;
        pos.z = Random.Range(-10, 10);
        objeto.transform.position = pos;
        objeto.GetComponent<Renderer>().material.color = col;

    }

    public int Tipo
    {
        set
        {
            tipo = value;
        }
        get
        {
            return tipo;
        }
    }

    public Color Color_
    {
        set
        {
            col = value;
        }
        get
        {
            return col;
        }
    }

    public string Name
    {
        set
        {
            name = value;
        }
        get
        {
            return name;
        }
    }

    public int Edad
    {
        set
        {
            edad = value;
        }
        get
        {
            return edad;
        }
      
    }

    public GameObject Objeto
    {
        set
        {
            objeto = value;
        }
        get
        {
            return objeto;
        }
    }
}
