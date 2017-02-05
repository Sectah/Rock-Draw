using UnityEngine;
using System.Collections;

public class destroySelf : MonoBehaviour {

    void Start()
    {
        Destroy(gameObject, 10);
    }
}
