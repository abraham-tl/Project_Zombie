using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public int numboxes; //Variable para asignar numeros de instancia
    public GameObject[] boxes; //Vector para guardar los personajes
    
    
    void Start ()
    {
        //Se define un vector para nombre y se llena 
 

        numboxes = Random.Range(10, 20);//Se asigna un valor aleatorio para la cantidad de instancias
        boxes = new GameObject[numboxes];//Se define el valor del vector donde se guandan los personjes
        
        //Ciclo para crear las instancias
        for (int k = 0; k < numboxes; k++)
        {
            
            GameObject cube =  GameObject.CreatePrimitive(PrimitiveType.Cube); //se crea una primitiva en la variable Game Object
            cube.transform.position = Asignar_Posicion();//Se asigna una posisicion en el plano
            cube.AddComponent<Rigidbody>();

           // Si es el primer cilo crea una instancia del heroe
            if (k == 0)
            {
                cube.AddComponent(typeof(Hero));                   
                boxes[k] = cube;//Se Guarda el Gameobject de la clase en el vector
            }

            else
            {
                int tipo = Random.Range(1, 3); //Aleatorio entre 1 y 2 para instanciar zombi o ciudadano
                if (tipo == 2)
                {
                    cube.AddComponent(typeof(Zombie));                  
                    boxes[k] = cube;//Se Guarda el Gameobject de la calse en el vector
                }
                else
                {
                   cube.AddComponent(typeof(Ciudadano));
                   cube.tag = "Ciudadano";
                   boxes[k] = cube;   //Se Guarda el Gameobject de la calse en el vector
                }
            }
        }
    }

    
   

    //Funcion que retorna un Vector3 para la posicion
    Vector3 Asignar_Posicion()
    {
        Vector3 pos = new Vector3();
        pos.x = Random.Range(-10, 10);
        pos.y = -0.5f;
        pos.z = Random.Range(-10, 10);
        return pos;
    }
}
