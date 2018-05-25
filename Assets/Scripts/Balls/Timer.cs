using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{

    public Image _cible;
    public Text _textEnd;
    public Slider _slider;
    public Button _btnTryAgain;
    public ShootBall _shootBall;

    bool _Won = false;
    public delegate void EndTimer();
    public static event EndTimer OnEndTime;
    public static event EndTimer OnStartTime;

    private void Start()
    {
        ShootBall.OnVictory += GameWon; // on s'abonne
    }

    private void GameWon()
    {
        _Won = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (_slider.value > 0)//......pertinant?
        {
            _slider.value = _slider.value - 0.0009f;

        }
        else
        {
            End();
            if (_Won)
            {
                _textEnd.gameObject.SetActive(true);
                _textEnd.text = "G A G N É ! \n" + _shootBall._nbBallsDead + " points";
                _textEnd.color = Color.green;
            }
            else if (!_Won)
            {
                _textEnd.gameObject.SetActive(true);
                _textEnd.text = " P E R D U ! \n" + _shootBall._nbBallsDead + " points";
                _textEnd.color = Color.red;
            }

        }
    }



    public void Restart()
    {

        //set values
        _slider.value = 1;
        _Won = false;
        _shootBall._nbBallsDead = 0;
        _shootBall._EndTime = false;

        //visible or not
        _cible.gameObject.SetActive(true);
        _textEnd.gameObject.SetActive(false);
        _btnTryAgain.gameObject.SetActive(false);

        CheckStartTime();
    }


    private void End()
    {
        _cible.gameObject.SetActive(false);
        _btnTryAgain.gameObject.SetActive(true);
        CheckEndTime();

    }



    public void CheckEndTime()
    {

        if (OnEndTime != null)
        {
            OnEndTime();
        }
    }


    public void CheckStartTime()
    {
        if (OnStartTime != null)
        {
            OnStartTime();
        }
    }
}
