using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Struc_Zombie
{
    //public string zombie_nombre_color;
    //public string zombie_gusto;
    //public Color zombie_color;
}

public struct Struc_Hero
{
    public float speed;
}

public struct Struc_Ciudadano
{
    public int edad;
    public Ciudadano_Nombre nombre;
}

public enum Ciudadano_Nombre
{
    ABRAHAN, STUBBS, ROB, WHITE, JOSE, WILLIAM, JUANFER, ELKIN, ANDRES, SANTIAGO, FEDRY, ALEJO, VICTOR, SANDRA, LUIS, ISABEL, PEDRO, PABLO, JASINTO, ANDREA
};



public enum Zombie_Gusto
{
Cabeza,Manos,Cuerpo,Pies,Cerebro
};


public enum Zombie_Estado
{
    Idle,Moving
};





