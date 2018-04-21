using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
    public int numboxes;
    public float spacing;
    public GameObject[] boxes;
    GameObject objecto;
    int edad_;
    string name_color ="";
    void Start () {
        string[] names = new string[]
        {
            "ABRAHAN","STUBBS","ROB","WHITE","JOSE","WILLIAM","JUANFER","ELKIN","ANDRES","SANTIAGO","FEDRY","ALEJO","VICTOR","SANDRA","LUIS","ISABEL","PEDRO","PABLO ","JASINTO JOSE","ANDREA",
        };

        numboxes = Random.Range(5, 11);
        boxes = new GameObject[numboxes];

        for (int k = 0; k < numboxes; k++)
        {
            edad_ = Random.Range(15, 101);
            int tipo = Random.Range(1, 3);

            if (k == 0)
            {
                Zombie z = new Zombie(0,Color.black , names[0], edad_);
                boxes[k] = z.Objeto;
                objecto = z.Objeto;
                objecto.AddComponent(typeof(Move_Player));
                //objecto.AddComponent(typeof(Move_Player));
                objecto.AddComponent<Camera>();
            }

            else
            {
                Color col;               
                if (tipo == 2)
                {
                    col = Color.gray;
                }
                else
                {
                     col = Colores();
                }
                Zombie z = new Zombie(tipo,col,names[k], edad_);
                boxes[k] = z.Objeto;
                int otro = Random.Range(1, 2);
                if (tipo == 2)
                {             
                    print(z.Name);
                }
                else if (tipo ==1)
                {
                    print(z.Name + " " + name_color );
                }
                //objecto = GameObject.CreatePrimitive(PrimitiveType.Cube);
                //Zombie z = new Zombie(names[1], Random.Range(10, 15), objecto);
            }
        }       
	}
	
	// Update is called once per frame
	void Update () {

    }

    Color Colores()
    {
        int col = Random.Range(1, 4);
        if (col == 1)
        {
            name_color = "AZUL";
            return Color.blue;      
        }
        else if (col == 2)
        {
            name_color = "VERDE";
            return Color.green;
        }
        else if (col == 3)
        {
            name_color = "ROJO";
            return Color.red;
        }
        else
            return Color.gray;
    }
}
