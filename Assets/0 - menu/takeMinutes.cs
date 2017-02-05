using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class takeMinutes : MonoBehaviour {

    public GameObject minutesInput;

    public void Start()
    {
        InputField inputField = minutesInput.GetComponent<InputField>();
        //Debug.Log(inputField.text);
        var timer = inputField.text;
        PlayerPrefs.SetString("minutes", timer);
    }
}
