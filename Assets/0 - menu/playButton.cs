using UnityEngine;
using System.Collections;

public class playButton : MonoBehaviour {

    public void playGame() {
        Application.LoadLevel("1 - game");
    }

    //void Update()
    //{
    //    if (Input.GetButtonDown("Submit"))
    //    {
    //        Application.LoadLevel("1 - game");
    //    }
    //}

}
