using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaDev : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Teste!");
	}
	
	// Update is called once per frame
	void Update () {
		  if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Pressionou E, parabens mano");
        }
            if (Input.GetKeyUp(KeyCode.E))
        {
            Debug.Log("Despressionou E, parabens tambem mano");
        }
	}
}