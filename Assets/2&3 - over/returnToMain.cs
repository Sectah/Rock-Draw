using UnityEngine;
using System.Collections;

public class returnToMain : MonoBehaviour {

	void Update () {
		if(Input.GetButtonDown("Cancel")){
			Application.LoadLevel("0 - menu");
		}
	}

	public void ButtonPress (){
		Application.LoadLevel ("0 - menu");
	}
}
