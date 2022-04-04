using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour {
    public int num1;
	// Use this for initialization
	void Start () {
        if((num1 % 2) == 0)
        {
            Debug.Log(num1 + " es par");
        }
        else
        {
            Debug.Log(num1 + " es impar");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
