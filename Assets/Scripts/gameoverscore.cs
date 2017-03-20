using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameoverscore : MonoBehaviour {
    public Text goscoreText;
	// Use this for initialization
	void Start () {
        goscoreText.text = "Score: " + score.skor;
        score.skor = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   
}
