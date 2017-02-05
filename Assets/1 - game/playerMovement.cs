using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 6f;
	Animator anim;

	void Start()
	{
		anim = GetComponent<Animator> ();
	}

    void Update()
    {
		if (Input.GetAxisRaw ("Vertical") > 0) 
		{
			anim.SetInteger("normClimb", 1);
			transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
		}

		if (Input.GetAxisRaw ("Vertical") < 0) 
		{
			anim.SetInteger("normClimb", -1);
			transform.Translate(Vector3.up * Time.deltaTime * -moveSpeed);
		}

		if (Input.GetAxisRaw ("Vertical") == 0) 
		{
			anim.SetInteger("normClimb", 0);
		}

		if (Input.GetAxisRaw ("Horizontal") > 0) 
		{
			transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
		}

		if (Input.GetAxisRaw ("Horizontal") < 0) 
		{
			transform.Translate(Vector3.right * Time.deltaTime * -moveSpeed);
		}

		Vector3 p = this.transform.position;
		this.transform.position = new Vector3( Mathf.Clamp( p.x, -4.8f, 4.9f ), Mathf.Clamp(p.y, -4.0f, 3.9f), p.z );

        //transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
        //transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
		//Debug.Log(Input.GetAxisRaw ("Vertical"));
    }
}
