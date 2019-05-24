using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LenseScaleController : MonoBehaviour {

    private int step;

    public int stepLimit;

    public float interpolationStep;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Increase()
    {
        if (step >= stepLimit)
            return;

        step++;
        transform.localScale += new Vector3(0, interpolationStep, 0);
    }

    public void Decrease()
    {
        if (step <= -stepLimit)
            return;

        step--;
        transform.localScale -= new Vector3(0, interpolationStep, 0);
    }
}
