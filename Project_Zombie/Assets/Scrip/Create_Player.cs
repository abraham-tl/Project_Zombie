using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class Create_Player : MonoBehaviour {
public class Create_Player 
{
    // Use this for initialization
    void Start () {
        Create_player();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Create_player()
    {
        GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
        go.GetComponent<Renderer>().material.color = Color.yellow;
        go.AddComponent(typeof (Move_Player));
    }
}
