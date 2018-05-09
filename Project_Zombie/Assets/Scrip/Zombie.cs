using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
   public Zombie_Gusto zombie_gusto;
    public Zombie_Estado zombie_estado;
    float speed = 0.1f;
    int forward ;
    int right;

    string name_color = ""; //Variable para guardar el nombre del color

    void Start()
    {
        zombie_gusto = (Zombie_Gusto)Random.Range(0, 5);
        gameObject.tag = "Zombie";
        gameObject.GetComponent<Renderer>().material.color = Asignar_Color();
        StartCoroutine(Timer_());
    }

    void Update()
    {
       
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
        zombie_estado = (Zombie_Estado)Random.Range(0, 2);
       
        StartCoroutine(Timer_());      
    }

    void Movimiento_Zombie(int forward,int  right)
    {
       
        if (forward == 1)
        {
            transform.position += transform.forward * speed;
        }
        else
        {
            transform.position -= transform.forward * speed;
        }
        if (right == 2)
        {
            transform.position -= transform.right * speed;
        }
        else
        {
            transform.position += transform.right * speed;
        }
    }
}
