using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie  {

    public string name;
    public int brainseten;
    public int hitpoints;
    GameObject zombiemesh;

    public Zombie(string n,int hp)
    {
        name = n;
        brainseten = 0;
        hitpoints = hp;
        zombiemesh = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        Vector3 pos = new Vector3();
        pos.x = Random.Range(-10,10);
        pos.y = 0f;
        pos.z = Random.Range(-10, 10);
        zombiemesh.transform.position = pos;

    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
