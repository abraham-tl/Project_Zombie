using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum States
{
    Idle, Moving, Rotating, Reacting
};

public enum Zombie_Gusto
{
    Cabeza, Manos, Cuerpo, Pies, Cerebro
};

public class NPCS : MonoBehaviour {
    public Vector3 rotating;
    public int edad = 0;
    public States state;
    public float speed = 0;
    public bool react;
    public bool stopeedReacting = true;

    // Use this for initialization
    void Start ()
    {
        inicializar();
    }
	
	// Update is called once per frame
	void Update ()
    {
        //if (react)
        //{
        //    state = States.Reacting;
        //    stopeedReacting = false;
        //}
        //else if (!stopeedReacting)
        //{
        //    stopeedReacting = true;
        //    state = States.Idle;
        //    StartCoroutine(DecideState());
        //}

        switch (state)
        {
            case States.Moving:
                Moving();
                // Movimiento_Zombie();

                break;

            case States.Rotating:
                Rotating();
                break;
        }


        //switch (state)
        //{
        //    case States.Idle:
        //        Debug.Log("Not moving");
        //        break;
        //    case States.Moving:
        //        Debug.Log("Moving");
        //        break;
        //    case States.Rotating:
        //        Debug.Log("Rotating");
        //        break;
        //    case States.Reacting:
        //        React();
        //        break;
        //}
    }

    IEnumerator DecideState()
    {
        yield return new WaitForSeconds(2);
        state = (States)Random.Range(0, 3);
        StartCoroutine(DecideState());
        rotating.y = Random.Range(-1,2);
    }

    public virtual void React()
    {
        StopAllCoroutines();
        Debug.Log("React");
    }

    public void inicializar()
    {
        edad = Random.Range(15,101);
        speed = ((100f - edad) / 50f);
        Corrutina();
    }

    public void Corrutina()
    {
        StartCoroutine(DecideState());
    }

    public void Moving()
    {
        transform.gameObject.transform.position += transform.forward * speed * Time.deltaTime;
    }

    public void Rotating()
    {
        transform.gameObject.transform.eulerAngles += rotating * speed;
    }
}
