using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    const int max_NPC = 25;
    Struc_Manager datos_manager;
    //Variable para asignar numeros de instancia


    public int numboxes; //Variable para asignar numeros de instancia

    public GameObject[] boxes; //Vector para guardar los personajes

   
    void Start ()
    {
        datos_manager = new Struc_Manager(Random.Range(5, 15));

        numboxes = Random.Range(datos_manager.min_NPC,max_NPC);
        boxes = new GameObject[numboxes];//Se define el valor del vector donde se guandan los personjes
        
        //Ciclo para crear las instancias
        for (int k = 0; k < numboxes; k++)
        {
            
            GameObject cube =  GameObject.CreatePrimitive(PrimitiveType.Cube); //se crea una primitiva en la variable Game Object
            cube.transform.position = Asignar_Posicion();//Se asigna una posisicion en el plano
            cube.AddComponent<Rigidbody>();// se asigna un rigidbodi al objeto
            if (k == 0)
            {
                cube.AddComponent(typeof(Hero));
                boxes[k] = cube;//Se Guarda el Gameobject de la calse en el vector
            }
            // Si es el primer cilo agrega el componente hero

            int tipo = Random.Range(1, 3); //Aleatorio entre 1 y 2 agregar el componente zombie o ciudadano             
                if (tipo == 2)
                {
                    // si es dos se agrega el componente Zombie
                    cube.AddComponent(typeof(Zombie));                  
                    boxes[k] = cube;//Se Guarda el Gameobject de la calse en el vector
                }
                else
                {
                    //si no es dos agrega el componente Ciudadano
                   cube.AddComponent(typeof(Ciudadano));
                   cube.tag = "Ciudadano";
                   boxes[k] = cube;   //Se Guarda el Gameobject de la calse en el vector
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
