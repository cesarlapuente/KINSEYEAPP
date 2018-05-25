using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {
    public Text _textScrore;
	// Use this for initialization
	void Start () {

        ShootBall.OnScore += ScoreGame;
        Timer.OnEndTime += RestartScore;
	}


    private void ScoreGame(int _score)
    {
        _textScrore.text = _score.ToString();
    }
	
    private void RestartScore(){
        _textScrore.text = "0";
    }
}
