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

    bool Won = false;

    private void Start()
    {
        ShootBall.OnVictory += GameWon; // on s'abonne
    }

    private void GameWon()
    {
        Won = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (_slider.value > 0)//......pertinant?
        {
            _slider.value = _slider.value - 0.001f;

        }
        else
        {
            End();

            if (Won)
            {
                _textEnd.gameObject.SetActive(true);
                _textEnd.text = "Winner you are ! ";
                _textEnd.color = Color.green;

            }
            else if (!Won)
            {
                _textEnd.gameObject.SetActive(true);
                _textEnd.text = "Looser you are ! ";
                _textEnd.color = Color.red;
            }

        }
    }



    public void Restart()
    {
        _cible.gameObject.SetActive(true);
        _textEnd.gameObject.SetActive(false);
        _btnTryAgain.gameObject.SetActive(false);
        _slider.value = 1;
        _shootBall._nbBallsDead = 0;//a verif
    }


    private void End()
    {
        _cible.gameObject.SetActive(false);
        _btnTryAgain.gameObject.SetActive(true);

    }
}
