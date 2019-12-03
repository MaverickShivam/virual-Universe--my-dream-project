using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour {
    public GameObject pushObject;
    float dangle, angle;

	// Use this for initialization
	void Start () {
        dangle = 0;
        angle = 0;
	}
	
	// Update is called once per frame
	void Update () {
        angle = angle + 1;
        if (angle <= 90)
        {
            gameObject.transform.Rotate(angle, 0, 0);
            WaitNSeconds(0.5f);
        }
        else if (angle > 90 && angle < 180)
        {
            gameObject.transform.Rotate(180-angle, 0, 0);
            WaitNSeconds(0.5f);
        }
        if (angle > 180)
        {
            angle = 0;
        }
        



    }
    private void WaitNSeconds(float segundos)
    {
        if (segundos < 1) return;
        DateTime _desired = DateTime.Now.AddSeconds(segundos);
        while (DateTime.Now < _desired)
        {
            dangle = dangle + 1;
        }
    }
}
