using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class getData : MonoBehaviour {
    
    public Text timerText;
    float minutesConverted;
    float minutesToSeconds;
    float secondsConverted;
    float timer;

	void Start () {
        var minutes = PlayerPrefs.GetString("minutes");
        var seconds = PlayerPrefs.GetString("seconds");
        float.TryParse(minutes, out minutesConverted);
        float.TryParse(seconds, out secondsConverted);
        minutesToSeconds = minutesConverted * 60.0f;
        timer = minutesToSeconds + secondsConverted;
        timerText.text = timer.ToString();
        InvokeRepeating("Countdown", 1.0f, 1.0f);
	}
    

    void Countdown()
    {
        if (--timer <= 0)
        {
            Application.LoadLevel("2 - player1wins");
        }
        timerText.text = timer.ToString();
    }

  
}
