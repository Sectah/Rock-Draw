using UnityEngine;
using System.Collections;

public class exitGame : MonoBehaviour {

	void Update () {
		if(Input.GetButtonDown("Cancel")){
			Application.Quit ();
		}
	}

	public void ButtonPress (){
		Application.Quit ();
	}
}