using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public Struc_Zombie datos_zombie;

    string name_color = ""; //Variable para guardar el nombre del color

    void Start()
    {
        datos_zombie.speed = 0.1f;
        datos_zombie.gusto = (Zombie_Gusto)Random.Range(0, 5);
        gameObject.tag = "Zombie";
        gameObject.GetComponent<Renderer>().material.color = Asignar_Color();
        StartCoroutine(Timer_());
    }

    void Update()
    {
        if (datos_zombie.estado == Zombie_Estado.Moving)
        {
            Movimiento_Zombie();
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

    IEnumerator Timer_()
    {
       yield return new WaitForSeconds(2);
        datos_zombie.estado = (Zombie_Estado)Random.Range(-1, 2);
        datos_zombie.moving_forward = Random.Range(-1, 2);
        datos_zombie.movin_right  = Random.Range(-1, 2);
        StartCoroutine(Timer_());      
    }

    void Movimiento_Zombie()
    {

        if (datos_zombie.moving_forward == 1 && transform.position.z <= 10)
        {
            transform.position += transform.forward * datos_zombie.speed;
        }
        else if (datos_zombie.moving_forward == -1 && transform.position.z >= -10)
        {
            transform.position -= transform.forward * datos_zombie.speed;
        }

        if (datos_zombie.movin_right == 1 && transform.position.x >= -10)
        {
             transform.position -= transform.right * datos_zombie.speed;
            //}
            //else
            //{
            //    transform.position += transform.right * datos_zombie.speed;
            //}
        }
    }
}
