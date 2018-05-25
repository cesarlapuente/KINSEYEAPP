using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {
    public Text _textScrore;
	// Use this for initialization
	void Start () {

        ShootBall.OnScore += ScoreGame;
        Timer.OnEndTime += DeactivateScore;
        Timer.OnStartTime += ActivateScore;
	}

    private void ScoreGame(int _score)
    {
       
        _textScrore.text = _score.ToString();
    }
	

    public void DeactivateScore()
    {
        _textScrore.gameObject.SetActive(false);
    }


    public void ActivateScore()
    {
        _textScrore.text = "0";
        _textScrore.gameObject.SetActive(true);
    }
}
