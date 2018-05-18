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

    [Range (-50, 50)]
    public float ax;

    [Range(-50, 50)]
    public float by;

    [Range(-50, 50)]
    public float cz;




    private void Start()
    {
        Physics.gravity = new Vector3(0, 0, 90);

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

        Instantiateballs();
        if(gyroEnabled){
            transform.localRotation = gyro.attitude * rot;
        }
    }



    public void Instantiateballs()
    {
        if (Time.time > _nextTime)
        {
            // to do : instantiate the ball with camera position 

            float x = Random.Range(-3, 3);//0
            float y = Random.Range(-2, 4);//1 ou -100 maybeÒ
            float z = Random.Range(-8, 20);//-5
            _newVector = new Vector3(x, 1, -5);//0,-4,20

            GameObject projectile = Instantiate(_balls, _newVector, Quaternion.identity) as GameObject;


            projectile.GetComponent<Rigidbody>().AddForce(new Vector3(0, 1, 0) *200);//200

            // ball.GetComponent<Rigidbody>().AddForce(Vector3.right * 200);

            //if ball don't destroy in 15 secondes, destroy it
            _nextTime = Time.time + 1f;




        }

    }



}
