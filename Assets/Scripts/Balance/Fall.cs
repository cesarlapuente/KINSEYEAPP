using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("dans fall");
        FallInDown();
	}


    public void FallInDown()
    {
        Rigidbody _rb = transform.GetComponent<Rigidbody>();
        _rb.isKinematic = true;
        _rb.useGravity = false;
        //permet de faire tomber la plateforme
        transform.Translate(transform.position.x / 20, 0, 0);// a declencher lorque le ontriggerenter sur la
        // /20 permet de ralentir la voitesse
        //plaque jaune est declenchée
        //penser a descativer le gytoscope -> faire des test avec et sans avec le telephone*/


    }
}
