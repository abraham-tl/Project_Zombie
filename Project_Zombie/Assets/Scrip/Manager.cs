using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
    //public int enemigos;
    public int numboxes;
    public float spacing;
    public GameObject[] boxes;
    GameObject objecto;
   
    // Use this for initialization
    void Start () {
        string[] names = new string[]
        {
            "ABRAHAN","STUBBS","ROB","WHITE","JOSE","WILLIAM","JUANFER","ELKIN","ANDRES","SANTIAGO","FEDRY","ALEJO","VICTOR","SANDRA","LUIS","ISABEL","PEDRO","PABLO ","JASINTO JOSE","ANDREA",
        };

        numboxes = Random.Range(5, 10);
        boxes = new GameObject[numboxes];

        for (int k = 0; k < numboxes; k++)
        {

            int tipo = Random.Range(1, 3);

            if (k == 0)
            {
                //objecto = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                Zombie z = new Zombie(0, Color.black ,names[0], 30);
                //objecto.AddComponent(typeof(Zombie));
                //objecto.AddComponent(typeof(Move_Player));

                //Camera cam = new Camera();
                ////cam.AddComponent(typeof(Movimiento_Camera));

                ////cam.transform.SetParent(objecto.transform);
                //objecto.AddComponent<Camera>();
            }

            else
            {
               
                int otro = Random.Range(1, 2);
                if (tipo == 1)
                {
                    Color coler = Colores();
                    Zombie z = new Zombie(tipo, coler, names[0], 30);
                }
                else if (tipo ==2)
                {
                    Zombie z = new Zombie(tipo, Color.white , names[0], 30);
                }
                

                
                //objecto = GameObject.CreatePrimitive(PrimitiveType.Cube);
                //Zombie z = new Zombie(names[1], Random.Range(10, 15), objecto);
            }

            //

            //Debug.Log(z.name);
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
    Color Colores()
    {
        int col = Random.Range(1,4);
        if (col == 1)
        {
            return Color.blue;
        }
        else if (col == 2)
        {
            return Color.green;
        }
        else if (col == 3)
        {
            return Color.red;
        }
        else
            return Color.gray;
    }
}
