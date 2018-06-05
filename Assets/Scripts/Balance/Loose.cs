using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loose : MonoBehaviour {

    public Gyro _gyro;// manager gyro
    public BalanceGame _balanceGame;// script balanceGame
    public Fall _fall;//script fallingdown

    void OnTriggerEnter(Collider other){
        _gyro.gameObject.SetActive(false);
        Debug.Log("apres desactiavtion du gyro");
        _balanceGame.enabled = false;
        Debug.Log("apres desactivation de ballgame");
        _fall.enabled = true;

        Debug.Log("apres activation de fall");
    }
}
