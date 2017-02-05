using UnityEngine;
using System.Collections;

public class hideAndShow : MonoBehaviour
{

    public GameObject stage1;
	public GameObject plane1;
    public GameObject stage2;
	public GameObject plane2;

    void Start() {
        stage1.SetActive(true);
		plane1.SetActive(true);
        stage2.SetActive(false);
		plane2.SetActive(false);
    }

    public void buttonPress() {
        stage1.SetActive(false);
		plane1.SetActive(false);
        stage2.SetActive(true);
		plane2.SetActive(true);
    }


}