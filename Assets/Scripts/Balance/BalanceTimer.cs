using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BalanceTimer : MonoBehaviour
{

   
    public Text _textEnd;
    public Slider _slider;
    public Button _btnTryAgain;


    bool _Won = true;
    public delegate void EndTimer();
    public static event EndTimer OnEndTime;
    public static event EndTimer OnStartTime;

    private void Start()
    {
        Loose.OnTriggerLoose += GameWon;
    }

    private void GameWon(int i)
    {
        _Won = false;
        Debug.Log(_Won + "est la valeur de won");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(_Won + "est la valeur de won dans l'update");
        if (_slider.value > 0 && _Won==true)
        {
            _slider.value = _slider.value - 0.0009f;

        }
        else
        {
            End();
            if (_Won)
            {
                _textEnd.gameObject.SetActive(true);
                _textEnd.text = "G A G N É ! ";
                _textEnd.color = Color.green;
            }
            else if (!_Won)
            {
                _textEnd.gameObject.SetActive(true);
                _textEnd.text = " P E R D U ! ";
                _textEnd.color = Color.red;
            }

        }
    }



    public void Restart()
    {

        //set values
        _slider.value = 1;
        _Won = false;
      
        //visible or not
   
        _textEnd.gameObject.SetActive(false);
        _btnTryAgain.gameObject.SetActive(false);

        CheckStartTime();
    }


    private void End()
    {
   
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
