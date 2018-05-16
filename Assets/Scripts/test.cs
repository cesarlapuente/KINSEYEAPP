using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {


    public GameObject prefab;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButton(0))
        {
            GameObject projectile = Instantiate((prefab)) as GameObject;
            projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 40;
        }
	}
}
