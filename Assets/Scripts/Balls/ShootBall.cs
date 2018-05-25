using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
    RaycastHit hitInfo;
    public int _nbBallsDead = 0;

    public bool _EndTime = false;

    public delegate void BallsEvent(); //function contener, defini un type like int or hamebobjet
    public delegate void BallsScore(int _score);
    public static event BallsEvent OnVictory;
    public static event BallsScore OnScore;


    // Use this for initialization
    void Start()
    {
        Timer.OnEndTime += ItsTheEnd;
    }

    public void ItsTheEnd()
    {
        _EndTime = true;
    }

    // Update is called once per frame
    public void Update()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitInfo, Mathf.Infinity))
        {
            if (!_EndTime)
            {
                Destroy(hitInfo.collider.gameObject);
                _nbBallsDead++;
                CheckVictory();
                CheckScore();
            }
        }
    }

    //for Score text in score script
    public void CheckScore()
    {
        if (OnScore != null)
        {
            OnScore(_nbBallsDead);
        }
    }

    //for End text in timer script
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

    public void CheckEndScore()
    {

    }
}
