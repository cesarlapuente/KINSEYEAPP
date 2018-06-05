using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TheDistance : MonoBehaviour {
    public Transform _target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      //  float angle = Vector3.Angle(transform.position, _target.position);
       float dist = Vector3.Distance(_target.position, transform.position);

        Debug.Log("Mask distance : "+ dist); 
	}
}
