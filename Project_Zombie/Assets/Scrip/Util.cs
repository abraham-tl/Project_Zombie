using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Estructura que contiene los datos del  Ciudadano
public struct Struc_Ciudadano
{
    public int edad;
    public Ciudadano_Nombre nombre;
}

//Enum para el numbre de los Ciudadanos
public enum Ciudadano_Nombre
{
    ABRAHAN, STUBBS, ROB, WHITE, JOSE, WILLIAM, JUANFER, ELKIN, ANDRES, SANTIAGO, FEDRY, ALEJO, VICTOR, SANDRA, LUIS, ISABEL, PEDRO, PABLO, JASINTO, ANDREA
};

//Estructura que contiene los datos del  Zombie
public struct Struc_Zombie
    {
    public Zombie_Gusto gusto;
    public Zombie_Estado estado;
    public float speed;
    public Vector3 direccion;
    public Vector3 rotation;
    };

//Enumeracion para el gusto del Zombie
public enum Zombie_Gusto
{
Cabeza,Manos,Cuerpo,Pies,Cerebro
};

// Enumeracion para movimiento del Zombie
public enum Zombie_Estado
{
    Idle,Moving,Rotating
}





