using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerTest : MonoBehaviour {


    public Slider _slider;
    int _timeend = 20;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.deltaTime < _timeend)
        {
            //float progress = Mathf.Clamp01(Time.time);
            Debug.Log(Time.deltaTime);
            _slider.value = Time.deltaTime + 1;

                
        }
	}
}
