using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    public int _TheTriggerNumber = 0;
    // Use this for initialization
    void Start()
    {
     //   Loose.OnTriggerLoose += NumberT;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("dans fall");
        FallInDown(_TheTriggerNumber);
    }


    public void FallInDown(int numb)
    {
        _TheTriggerNumber = numb;
        Rigidbody _rb = transform.GetComponent<Rigidbody>();
        _rb.isKinematic = true;
        _rb.useGravity = false;
        Debug.Log("the trigger number : " + _TheTriggerNumber );
        if (_TheTriggerNumber == 1)
        {
            transform.Translate(transform.position.y / 20, 0, 0);//gauche
            Debug.Log("gauche");
        }
        else if (_TheTriggerNumber == 2)
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
        //penser a descativer le gytoscope -> faire des test avec et sans avec le telephone*/
        Debug.Log("aprs le fillingdown");


    }


    public void NumberT (int _TriggerNumber)
    {
        if(_TriggerNumber == 1)
        {
            _TheTriggerNumber = _TriggerNumber;
        }
        else if(_TriggerNumber == 2)
        {
            _TheTriggerNumber = _TriggerNumber;
        }
    }

}
