using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loose : MonoBehaviour {

    public Gyro _gyro;// manager gyro
    public BalanceGame _balanceGame;// script balanceGame
    public Fall _fall;//script fallingdown

    //trigger 1 = left
    //trigger 2 = right
    public delegate void TriggerEvent(int _NumTrigger);
    public static event TriggerEvent OnTriggerLoose;
   

    void OnTriggerEnter(Collider other)
    {
      //  Debug.Log("apres desactivation de ballgame");
        _fall.enabled = true;
       // _gyro.gameObject.SetActive(false);
       // Debug.Log("apres desactiavtion du gyro");
        _balanceGame.enabled = false;
        //desactive le timer, descativer se script si le timer fini avant

        Debug.Log("mon nom " + other.gameObject.tag);

        if (other.gameObject.tag.Equals("L"))
        {
            //Debug.Log("dans le left losse" );
            if (OnTriggerLoose != null)
            {
                Debug.Log("dan le on trigger1left");
                OnTriggerLoose(1);
            }

        }
        if (other.gameObject.tag.Equals("R")) 
        {
           // Debug.Log("dans le right losse");
            if (OnTriggerLoose != null)
            {
                Debug.Log("dan le on trigger2right");
                OnTriggerLoose(2);
            }
        }

       // Debug.Log("apres activation de fall");
    }
}
