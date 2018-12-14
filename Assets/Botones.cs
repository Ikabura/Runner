using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones : MonoBehaviour {
	public Button Options, Play, Exit;

	// Use this for initialization
	void Start () {
		Play.onClick.AddListener(play);
		Options.onClick.AddListener(options);
		Exit.onClick.AddListener(exit);

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void play () {

	}
	void options () {

	}
	void exit () {

	}

}
