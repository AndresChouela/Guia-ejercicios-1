using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7 : MonoBehaviour {
    public int num1;
    public int num2;
    public int num3;
	// Use this for initialization
	void Start () {
		if (num1 > num2)
        {
            if (num1 > num3)
            {
                Debug.Log("El numero mayor es " + num1);
            }
            else if (num1 < num3)
            {
                Debug.Log("El numero mayor es " + num3);
            }
        }
        else if (num1 < num2)
        {
            if (num2 > num3)
            {
                Debug.Log("El numero mayor es " + num2);
            }
            else if (num2 < num3)
            {
                Debug.Log("El numero mayor es " + num3);
            }
        }
        else if (num1 == num2 && num2 == num3)
        {
            Debug.Log("El numero mayor es " + num3);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
