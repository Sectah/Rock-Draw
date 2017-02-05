using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class takeSeconds : MonoBehaviour {

    public GameObject secondsInput;

    public void Start()
    {
        InputField inputField = secondsInput.GetComponent<InputField>();
        //Debug.Log(inputField.text);
        var test = inputField.text;
        PlayerPrefs.SetString("seconds", test);
    }
}
