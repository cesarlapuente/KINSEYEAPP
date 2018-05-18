using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
    RaycastHit hitInfo;
    public int _nbBallsDead = 0;
    public delegate void BallsEvent(); //function contener, defini un type like int or hamebobjet

    public static event BallsEvent OnVictory;

    // Use this for initialization
    void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitInfo, Mathf.Infinity))
        {
            Destroy(hitInfo.collider.gameObject);
            _nbBallsDead++;
            CheckVictory();
        }
    }


    public void CheckVictory()
    {
        if (_nbBallsDead == 10)
        {
            if (OnVictory != null)// regarde si on a des abonnés
            {
                OnVictory();
            }
        }
    }
}
