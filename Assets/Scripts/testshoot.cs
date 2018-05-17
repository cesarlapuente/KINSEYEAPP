using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testshoot : MonoBehaviour {


    public GameObject prefab;
    private float fire = 2f;
    private float nextfire;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Time.time > nextfire)
        {
            nextfire = Time.time + fire;
            GameObject ball  = Instantiate(prefab, new Vector3(0,1,0), Quaternion.identity)as GameObject;
            ball.GetComponent<Rigidbody>().AddForce(Vector3.right * 200);
        }
	}
}
