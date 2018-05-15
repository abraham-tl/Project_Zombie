using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public Struc_Zombie datos_zombie = new Struc_Zombie(); //Se crea una varia ble de tipo stuc zombie
    string name_color = ""; //Variable para guardar el nombre del color
   
    void Start()
    {
        datos_zombie.direccion = Vector3.forward;
        datos_zombie.speed = 0.5f; //Se asigna la velocidad del movimiento del zombie
        datos_zombie.gusto = (Zombie_Gusto)Random.Range(0, 5); // Se asigna un aleatorio para el enum del gusto del zombie
        gameObject.tag = "Zombie"; //Se le agraga untag al objeto zombie ("Zombie")
        gameObject.GetComponent<Renderer>().material.color = Asignar_Color(); // Se asigna un color aleatorio al zombie llamando un subproceso (Asignar color)
        StartCoroutine(Timer_()); // Se inicia la corrutina para el movimiento del Zombie
    }

    void Update()
    {
        //Caso para ejecutar el movimiento de los Zombies
        switch(datos_zombie.estado)
        {
            case Zombie_Estado.Idle:
                Movimiento_Zombie();
                break;
        }
       
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

    //Corutina para cambiar el estado del movimiento del zombie
    IEnumerator Timer_()
    {
       yield return new WaitForSeconds(2);
        datos_zombie.direccion.x = Random.Range(-1,2);
        datos_zombie.direccion.z = Random.Range(-1, 2);
        datos_zombie.estado = (Zombie_Estado)Random.Range(-1, 2);
        StartCoroutine(Timer_());      
    }

    //Desplaza el zombie por el plano
    void Movimiento_Zombie()
    {
        transform.Translate(datos_zombie.direccion * datos_zombie.speed*Time .deltaTime); 
    }
}
