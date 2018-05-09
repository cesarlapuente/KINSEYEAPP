using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {
    RaycastHit hitInfo;
	// Use this for initialization
	void Start () {
        Debug.Log("start");
	}
	
	// Update is called once per frame
	void Update () {
       
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitInfo,  Mathf.Infinity)){
            Destroy(hitInfo.collider.gameObject);       
            Debug.Log("Dead");
        }
	}
}
