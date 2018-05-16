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

    [Range (-280f, 280)]
    public float ax;

    [Range(-280f, 280)]
    public float by;

    [Range(-280f, 280)]
    public float cz;



    private void Start()
    {
        Physics.gravity = new Vector3(ax, -7.71f, -10.76f);

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
         
            return true;

        }

        return false;

    }




    private void Update()
    {
        ///////////////pour test sur pc ///////////////////
        if (Time.time > _nextTime)
        {
            //Debug.Log("ball instantiate : " + Time.time);

         
            //Instantiate(_balls, _newVector, transform.rotation);

            // to do : instantiate the ball with camera position 



            float x = Random.Range(-2, 3);
            float y = Random.Range(-7, 7);
            float z = Random.Range(15, 25);
            _newVector = new Vector3(0, -7, -20);//0,-4,20

            GameObject projectile = Instantiate(_balls, _newVector, Quaternion.identity) as GameObject;
            projectile.GetComponent<Rigidbody>().AddForce(0,0,0.5f, ForceMode.Impulse);
            //if ball don't destroy in 15 secondes, destroy it
            _nextTime = Time.time + 2f;
        }




            if (Time.time > _nextTime)
        {
            Debug.Log("ball instantiate : " + Time.time);

           

           // Instantiate(_balls, _newVector, transform.rotation);

            // to do : instantiate the ball with camera position 



            float x = Random.Range(-2, 3);
            float y = Random.Range(4, 7);
            float z = Random.Range(-5, 0);
            _newVector = new Vector3(0, -4, 10);

            GameObject projectile = Instantiate(_balls, _newVector, Quaternion.identity) as GameObject;
            projectile.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0.5f, 1) * 250);
            Physics.gravity = new Vector3(0, 180, 0);
            
            _nextTime = Time.time + 2f;
        }

        //////////////////////

        if(gyroEnabled){
            transform.localRotation = gyro.attitude * rot;

            if (Time.time > _nextTime)
            {
                Debug.Log("ball instantiate : " + Time.time);

                float x = Random.Range(-2, 3);
                float y = Random.Range(4, 7);
                float z = Random.Range(-5, 0);
                _newVector = new Vector3(0, -7, -20);//0,-4,20

                GameObject projectile = Instantiate(_balls, _newVector, Quaternion.identity) as GameObject;
                projectile.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0.5f, 1) * 1);
                //if ball don't destroy in 15 secondes, destroy it
                _nextTime = Time.time + 2f;
            }



        }
    }



}
