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
   
    
    public Zombie(int tipo,Color coler,string n,int edad)
    {
        name = n;
        edad = 0;
        //hitpoints = hp;
        objeto = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        Vector3 pos = new Vector3();
        pos.x = Random.Range(-10,10);
        pos.y = 0f;
        pos.z = Random.Range(-10, 10);
        objeto.transform.position = pos;
        objeto.GetComponent<Renderer>().material.color = coler;

    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    void colores()
    {

    }
}
