using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("start");
	}
	
	// Update is called once per frame
	void Update () {
        if(Physics.Raycast(transform.position, Vector3.forward)){
            Debug.Log("je suis rentré en colision avec quelque chose lolilol");
        }
	}
}
