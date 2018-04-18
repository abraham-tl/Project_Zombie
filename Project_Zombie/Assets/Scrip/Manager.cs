using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
    //public int enemigos;
    public int numboxes;
    public float spacing;
    public GameObject[] boxes;
    
   
	// Use this for initialization
	void Start () {
        string[] names = new string[]
        {
            "ABRAHAN","STUBBS","ROB","WHITE","JOSE","WILLIAM","JUANFER","ELKIN","ANDRES","SANTIAGO",
        };

        numboxes = Random.Range(5, 10);
        boxes = new GameObject[numboxes];

        for (int k = 0; k < numboxes ; k++)
        {
            Zombie z = new Zombie(names[k], Random.Range(10, 15));
            Debug.Log(z.name);
        }


        for (int k =0;k < numboxes; k++)
        {

            //GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);
            //box.AddComponent(typeof(Monster));
            //Monster m = box.GetComponent("Monster") as Monster;
            //m.id = k;
            //m.spacing = spacing;
            //boxes[k] = box;          
        }
        
        
	}
	
	// Update is called once per frame
	void Update () {
        //int i = 0;
        //foreach (GameObject go in boxes)
        //{
        //    float wave = Mathf.Sin(Time.fixedTime + i);
        //    go.transform.position = new Vector3(i * spacing, wave, 0);
        //    i++;
        //    print(Time.fixedTime);
        //}
    }

    void Names()
    {

        
        
    }
}
