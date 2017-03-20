using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
    public Text scoreText;
    static public int skor=0;
	// Use this for initialization
	void Start () {
        InvokeRepeating("count", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
  
    void count()
    {
        scoreText.text = "" + skor;
        skor++;
    }
}
