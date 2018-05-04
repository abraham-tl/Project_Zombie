using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    Zombie_Gusto zombie_dat;

    Color color_zombie;//Variable para el color que se le asigna al GameObject
    string name_color_zombie;//Variable para el nombre del color que se le asigna al GameObject
    GameObject zombie;//Variable para el GAmeObject de la clase
    string name_color = ""; //Variable para guardar el nombre del color

    void Start()
    {
        zombie_dat = new Zombie_Gusto();

        
        gameObject.tag = "Zombie";
        gameObject.GetComponent<Renderer>().material.color = Asignar_Color();
    }
    

    string Imprimir_Mensaje()
    {
        return "SOY UN ZOMBIE DE COLOR "+ name_color_zombie;//retorna el texto y el color
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
}
