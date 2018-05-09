using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour {

    public GameObject _balls;
    private Vector3 _newVector; 
    private float _nextTime = 2f;





	// Use this for initialization
	void Start () {
        //Time.time;
	}
	
	// Update is called once per frame
	void Update () {


        if(Time.time > _nextTime ){
            Debug.Log("ball instantiate : " + Time.time);
            /*
            float x = Random.Range(-2, 3);
            float y = Random.Range(4, 7);
            float z = Random.Range(0, 5);
            _newVector = new Vector3(x, y, z);*/
            /*
            Instantiate(_balls, _newVector, transform.rotation);
            */
            // to do : instantiate the ball with camera position 



            float x = Random.Range(-2, 3);
            float y = Random.Range(4, 7);
            float z = Random.Range(0, 5);
            _newVector = new Vector3(x, y, z);
            
            GameObject projectile = Instantiate(_balls, Camera.main.transform.position, Quaternion.identity) as GameObject;
            projectile.GetComponent<Rigidbody>().AddForce( new Vector3(0,0.5f,1) * 500);

            //if ball don't destroy in 15 secondes, destroy it
            _nextTime = Time.time + 6f;
        }

      
	}
}
