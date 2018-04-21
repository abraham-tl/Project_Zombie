using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
    public int numboxes; //Variable para asignar numeros de instancia
    public GameObject[] boxes; //Vector para guardar los personajes
    string name_color =""; //Variable para guardar el nombre del color

    void Start () {
        //Se define un vector para nombre y se llena 
        string[] names = new string[]
        {
            "ABRAHAN","STUBBS","ROB","WHITE","JOSE","WILLIAM","JUANFER","ELKIN","ANDRES","SANTIAGO","FEDRY","ALEJO","VICTOR","SANDRA","LUIS","ISABEL","PEDRO","PABLO ","JASINTO JOSE","ANDREA",
        };

        numboxes = Random.Range(5, 11);//Se asigna un valor aleatorio para la cantidad de instancias
        boxes = new GameObject[numboxes];//Se define el valor del vector donde se guandan los personjes

        //Ciclo para crear las instancias
        for (int k = 0; k < numboxes; k++)
        {
            Vector3 pos = Asignar_Posicion();//Se asigna una posisicion en el plano

            //Si es el primer cilo crea una instancia del heroe
            if (k == 0)
            {
                Hero  h = new Hero(pos); //Se instancia una clase heroe enviandole la posicion 
                boxes[k] = h.Hero_;//Se Guarda el Gameobject de la clase en el vector
            }

            else
            {
                int tipo = Random.Range(1, 3); //Aleatorio entre 1 y 2 para instanciar zombi o ciudadano
                print(tipo);
                if (tipo == 2)
                {
                    Color col = Asignar_Color(); //se invoca un procedimiento para asignar color aleatorio
                    Zombie z = new Zombie(col,name_color,pos); //Se instancia la clase Zombie enviandole los parametros color, nombre del color y la posicion
                    boxes[k] = z.Zombie_;//Se Guarda el Gameobject de la calse en el vector
                }
                else
                {
                    Ciudadano c = new Ciudadano(names[k], pos);//Se instancia la clase Ciudadano enviandole los parametros nombre  y la posicion
                    boxes[k] = c.Ciudadano_;   //Se Guarda el Gameobject de la calse en el vector
                }     
            }
        }       
	}
	
	// Update is called once per frame
	void Update () {

    }

    //Funcion que retorna un color aleatorio 
    Color Asignar_Color()
    {
        int col = Random.Range(1, 4);//se asigna un numero aleatorio en una variable entre 1 y 3
        if (col == 1)//Si la variable es igual a 1 retorna el color azul
        {
            name_color = "AZUL";
            return Color.blue;      
        }
        else if (col == 2)//Si la variable es igual a 2 retorna el color Verde
        {
            name_color = "VERDE";
            return Color.green;
        }
        else if (col == 3)//Si la variable es igual a 3 retorna el color Rojo
        {
            name_color = "ROJO";
            return Color.red;
        }
        else //Si es un numero diferente retorna Gris
            return Color.gray;
    }

    //Funcion que retorna un Vector3 para la posicion
    Vector3 Asignar_Posicion()
    {
        Vector3 pos = new Vector3();
        pos.x = Random.Range(-10, 10);
        pos.y = 0f;
        pos.z = Random.Range(-10, 10);
        return pos;
    }
}
