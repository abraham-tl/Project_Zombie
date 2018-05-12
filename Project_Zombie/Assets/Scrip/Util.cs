﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct Struc_Ciudadano
{
    public int edad;
    public Ciudadano_Nombre nombre;
}

public enum Ciudadano_Nombre
{
    ABRAHAN, STUBBS, ROB, WHITE, JOSE, WILLIAM, JUANFER, ELKIN, ANDRES, SANTIAGO, FEDRY, ALEJO, VICTOR, SANDRA, LUIS, ISABEL, PEDRO, PABLO, JASINTO, ANDREA
};


public struct Struc_Zombie
    {
    public Zombie_Gusto gusto;
    public Zombie_Estado estado;
    public float speed;
    public Vector3 direccion;
    };


public enum Zombie_Gusto
{
Cabeza,Manos,Cuerpo,Pies,Cerebro
};


public enum Zombie_Estado
{
    Idle,Moving
};




