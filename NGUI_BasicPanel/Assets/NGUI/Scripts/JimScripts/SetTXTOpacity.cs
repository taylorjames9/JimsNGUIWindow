using UnityEngine;
using System.Collections;

public class SetTXTOpacity : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}


	public void SetTXTAlpha(){
			
		UILabel labl = GetComponent<UILabel> ();
		labl.alpha = UIProgressBar.current.value;

		}
}
