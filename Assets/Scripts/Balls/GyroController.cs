using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroController : MonoBehaviour
{

    private bool gyroEnabled;
    private Gyroscope gyro;
    private GameObject cameraContainer;
    private Quaternion rot;

    public GameObject _balls;
    private Vector3 _newVector;
    private float _nextTime = 2f;




    private void Start()
    {
        cameraContainer = new GameObject("Camera Container");
        cameraContainer.transform.position = transform.position;
        transform.SetParent(cameraContainer.transform); 

        gyroEnabled = EnableGyro();
    }



    private bool EnableGyro(){
        if(SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
            cameraContainer.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
            rot = new Quaternion(0, 0, 1, 0);
                
            if (Time.time > _nextTime)
            {
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

                GameObject projectile = Instantiate(_balls, cameraContainer.transform.position, rot) as GameObject;
                projectile.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0.5f, 1) * 500);

                //if ball don't destroy in 15 secondes, destroy it
                _nextTime = Time.time + 6f;
            }


            return true;

        }

        return false;

    }




    private void Update()
    {
        if(gyroEnabled){
            transform.localRotation = gyro.attitude * rot;

            if (Time.time > _nextTime)
            {
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
                float z = Random.Range(-5, 0);
                _newVector = new Vector3(0, 20, 0);

                GameObject projectile = Instantiate(_balls, _newVector, Quaternion.identity) as GameObject;
                projectile.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0.5f, 1) * 500);
                Physics.gravity = new Vector3(0, 180, 0);
                //if ball don't destroy in 15 secondes, destroy it
                _nextTime = Time.time + 2f;
            }


        }
    }



}
