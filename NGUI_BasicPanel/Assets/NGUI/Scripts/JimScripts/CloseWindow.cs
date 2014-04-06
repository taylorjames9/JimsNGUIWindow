using UnityEngine;
using System.Collections;

public class CloseWindow : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void ShutItDown(){
		gameObject.SetActive (false);

	}
	public void OpenItUp(){
		gameObject.SetActive (true);

	}

}
