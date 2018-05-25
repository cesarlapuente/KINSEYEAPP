using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
    RaycastHit hitInfo;
    public int _nbBallsDead = 0;
    public Timer _endTimer;




    public delegate void BallsEvent(); //function contener, defini un type like int or hamebobjet
    public delegate void BallsScore(int _score);
    public static event BallsEvent OnVictory;
    public static event BallsScore OnScore;

    // Use this for initialization
    void Start()
    {
      
    }

    // Update is called once per frame
    public void Update()
    {
        Debug.Log(_endTimer);
        //Debug.Log("balls : " + _nbBallsDead);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitInfo, Mathf.Infinity))
        {
            if(_endTimer._endTime == false)
            {
                Destroy(hitInfo.collider.gameObject);
                _nbBallsDead++;
                CheckVictory();
                CheckScore();
            }
        }
    }

    //for text Score
    public void CheckScore()
    {
        if(OnScore != null )
        {
            OnScore(_nbBallsDead);
        }
    }

    //for end text in scipt timer
    public void CheckVictory()
    {
        
        if (_nbBallsDead == 8)
        {
            if (OnVictory != null)// regarde si on a des abonnés
            {
                OnVictory();
            }
        }
    }
}
