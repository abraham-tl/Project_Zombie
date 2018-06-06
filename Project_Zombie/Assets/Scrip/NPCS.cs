using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum States
{
    Idle,
    Moving,
    Rotating,
    Reacting
}
public class NPCS : MonoBehaviour {
    public States state;
    public bool react;
    public bool stopeedReacting = true;

    // Use this for initialization
    void Start () {
        StartCoroutine(DecideState());
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (react)
        {
            state = States.Reacting;
            stopeedReacting = false;
        }
        else if (!stopeedReacting)
        {
            stopeedReacting = true;
            state = States.Idle;
            StartCoroutine(DecideState());
        }

        switch (state)
        {
            case States.Idle:
                Debug.Log("Not moving");
                break;
            case States.Moving:
                Debug.Log("Moving");
                break;
            case States.Rotating:
                Debug.Log("Rotating");
                break;
            case States.Reacting:
                React();
                break;
        }

    }

    IEnumerator DecideState()
    {
        yield return new WaitForSeconds(2);
        state = (States)Random.Range(0, 3);
        StartCoroutine(DecideState());
    }

    public virtual void React()
    {
        StopAllCoroutines();
        Debug.Log("React");
    }
}
