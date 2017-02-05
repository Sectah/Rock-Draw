using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Enemy") {
            Application.LoadLevel("3 - player2wins");
        }
    }
}
