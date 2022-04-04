using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4 : MonoBehaviour {
    public int num1;
    public int num2;
	// Use this for initialization
	void Start () {
        int resultado = num1 + num2;
        Debug.Log("La suma entre " + num1 + " y " + num2 + " da como resultado " + resultado);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
