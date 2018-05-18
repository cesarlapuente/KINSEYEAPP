using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour {

    public Image _cible;
    public Text _textEnd;
    public Slider _slider;
    public Button _btnTryAgain;
	
	// Update is called once per frame
	void Update () {
        if (_slider.value > 0)//......pertinant?
        {
            _slider.value = _slider.value - 0.001f;
                
        }
        else
        {
            End();

            //if balls >5

            _textEnd.gameObject.SetActive(true);
            _textEnd.text = "Winner you are ! ";
            _textEnd.color = Color.green;


            //else
            _textEnd.gameObject.SetActive(true);
            _textEnd.text = "Looser you are ! ";
            _textEnd.color = Color.red;
        }
	}



    public void Restart()
    {
        _cible.gameObject.SetActive(true);
        _textEnd.gameObject.SetActive(false);
        _btnTryAgain.gameObject.SetActive(false);
        _slider.value = 1;

    }


    private void End()
    {
        _cible.gameObject.SetActive(false);
        _btnTryAgain.gameObject.SetActive(true);

    }
}
