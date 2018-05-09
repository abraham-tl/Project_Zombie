using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    Struc_Hero struc_hero = new Struc_Hero();
    GameObject hero;//Variable para el GAmeObject de la clase
    void Start()
    {
        struc_hero.speed = 5;
        gameObject.GetComponent<Renderer>().material.color = Color.gray;
        gameObject.AddComponent(typeof(FPSMove));//Se le asigna la clase FPSMove al GameObject para el movimiento
        gameObject.tag = "Hero";
       
        Camera.main.transform.localPosition = transform.position;//se le asigna a la camara la misposicion del heroe
        Camera.main.transform.SetParent(gameObject.transform);//se hace la camara hija del heroe
        Camera.main.gameObject.AddComponent<FPSAim>();//se le agrega la la clase FPSAim a la camara para la rotacion    
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {           
            Debug.Log("Waaaarrrr Quiero comer "+ collision.gameObject.GetComponent<Zombie>().zombie_gusto);
        }
        else if(collision.gameObject.tag == "Ciudadano")
        {
            Debug.Log("Hola soy  " + collision.gameObject.GetComponent<Ciudadano>().ciudadano_nombre + "y tengo " + collision.gameObject.GetComponent<Ciudadano>().edad + " años");
        }
    }
}
