using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalanceGame : MonoBehaviour {
    public Text _debugtexte;
    public Text _debugtest;
    public Transform _target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log("dans balance game");
        TurnWithGyro();
        //transform.eulerAngles(Mathf.Clamp(transform.eulerAngles.z, -90, 90));
        //_debugtexte.text = zRot.ToString();
        //   ClampAngle(zRot);
        //float zRot = Input.gyro.rotationRate.x;
        // float zRot = Input.gyro.rotationRate.y;
      //  transform.Translate(0, transform.position.y, 0);
        //  transform.Translate(0, 0, transform.position.z);

        //  Physics.gravity = Input.gyro.gravity;
	}

    public void TurnWithGyro(){
        // permet de balance sur un axe la plaque avec le gyroscope
        float zRot = Input.gyro.rotationRate.z;
        transform.Rotate(Vector3.forward, zRot * Time.deltaTime * 950);

    }
 
       
 






    void ClampAngle(float angle)
    {
        
        // accepts e.g. -80, 80
        if (angle < 0.002f) 
        {
            Debug.Log("OUT");
        }


        /*
        if (angle > 180f) 
        {
            _debugtexte.text = "SUPERIEUR";
        }
        return Mathf.Min(angle, to);*/
    }

    void fall()
    {
        Physics.gravity = Input.gyro.gravity;
    }
}
