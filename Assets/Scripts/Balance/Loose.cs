using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loose : MonoBehaviour {

    public Gyro _gyro;// manager gyro
    public BalanceGame _balanceGame;// script balanceGame
    public Fall _fall;//script fallingdown

    int nbtrigger;
    //trigger 1 = left
    //trigger 2 = right
    public delegate void TriggerEvent();
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
            nbtrigger = 1;
                Debug.Log("dan le on trigger1left");
         
        }
        if (other.gameObject.tag.Equals("R")) 
        {
            // Debug.Log("dans le right losse");
            nbtrigger = 2;
                Debug.Log("dan le on trigger2right");
        
        }

        if(OnTriggerLoose!=null){
            OnTriggerLoose();
        }
        Debug.Log(nbtrigger);
        _fall.FallInDown(nbtrigger);

       // Debug.Log("apres activation de fall");
    }
}

/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    public int _TheTriggerNumber = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("dans fall");
        FallInDown(_TheTriggerNumber);
    }


    public void FallInDown(int triggerNumber)
    {
        _TheTriggerNumber = triggerNumber;
        Rigidbody _rb = transform.GetComponent<Rigidbody>();
        _rb.isKinematic = true;
        _rb.useGravity = false;
        Debug.Log("the trigger number : " + _TheTriggerNumber);
        if (triggerNumber == 1)
        {
            transform.Translate(transform.position.y / 20, 0, 0);//gauche
            Debug.Log("gauche");
        }
        else if (triggerNumber == 2)
        {
            transform.Translate(transform.position.x / 20, 0, 0);//droit
            Debug.Log("droit");
        }

        ////transform.Translate(transform.position.x/20, 0, 0);//droit
        /////  transform.Translate(transform.position.y / 20, 0, 0);//gauche
        //permet de faire tomber la plateforme
        //transform.Translate(-transform.position.x ,-0.5f , 0);// a declencher lorque le ontriggerenter sur la
        // /20 permet de ralentir la voitesse
        //plaque jaune est declenchée
        //penser a descativer le gytoscope -> faire des test avec et sans avec le telephone
        Debug.Log("fin");


    }





    public void NumberT(int _TriggerNumber)
    {
        if (_TriggerNumber == 1)
        {
            _TheTriggerNumber = _TriggerNumber;
        }
        else if (_TriggerNumber == 2)
        {
            _TheTriggerNumber = _TriggerNumber;
        }
    }

}
*/