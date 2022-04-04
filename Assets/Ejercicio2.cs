using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int num1 = 4;
        int num2 = 5;
        Debug.Log(num1 += num2);
        num1 = 4;
        Debug.Log(num1 *= num2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
