using UnityEngine;
using System.Collections;

public class enemyMovement : MonoBehaviour {

    public float moveSpeed = 3f;

	void Update () {
        transform.position += Vector3.down * Time.deltaTime * moveSpeed;
    }
}
