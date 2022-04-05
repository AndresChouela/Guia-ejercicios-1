using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour {
    public float capital1;
    public float capital2;
    public float capital3;
    public string nombre1;
    public string nombre2;
    public string nombre3;
    // Use this for initialization
    void Start () {
        float montototal = capital1 + capital2 + capital3;
        float porcentaje1 = capital1 / montototal * 100;
        float porcentaje2 = capital2 / montototal * 100;
        float porcentaje3 = capital3 / montototal * 100;
        Debug.Log("Nombre:" + nombre1 + ",capital aportado: $" + capital1 + ", Porcentaje del capital: " + porcentaje1 + "%, Monto total aportado: $" + montototal);
        Debug.Log("Nombre: " + nombre2 + ", capital aportado: $" + capital2 + ", Porcentaje del capital: " + porcentaje2 + "%, Monto total aportado: $" + montototal);
        Debug.Log("Nombre: " + nombre3 + ", capital aportado: $" + capital3 + ", Porcentaje del capital: " + porcentaje3 + "%, Monto total aportado: $" + montototal);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
