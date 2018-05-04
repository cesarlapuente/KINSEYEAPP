using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour {

    Rect _crosshairRect;
    public Texture _crosshairTexture;

	// Use this for initialization
	void Start () {

        float crosshairsize = Screen.width * 0.1f;
        _crosshairTexture = Resources.Load("Images/Blackcrosshair") as Texture;
        _crosshairRect = new Rect(Screen.width/2-crosshairsize/2, Screen.height/2-crosshairsize/2,crosshairsize,crosshairsize);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        GUI.DrawTexture(_crosshairRect,_crosshairTexture);
    }

}
