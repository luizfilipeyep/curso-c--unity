using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaFor : MonoBehaviour {

	public int Contador;
	public int[] ArrayInt = {1, 2, 3, 4, 5};

	// Use this for initialization
	void Start () {
		// Laço For
		/*
		for (int i = 0; i < Contador; i++)
		{
			Debug.Log(i);
		}
		*/

		// FOREACH
		/*
		foreach (int Valor in ArrayInt)
		{
			Debug.Log(Valor);
		}
		*/
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
