using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float walkSpeed = 10.0f;
	public float g = 10.0f;

	private int mainSpeed = 100;
	private GameObject PlayerChar ;
	// Use this for initialization
	void Start () {
		//PlayerChar = GetComponent<this.gameObject>();
	}
	
	void FixedUpdate(){
		//PlayerMove ();
		Movement ();
	}
	void Update () {
		//PlayerMove ();
		//Movement ();

	}

	private void Movement()
	{
		if (Input.GetKey(KeyCode.D)) {
			transform.Translate(Vector2.right * walkSpeed *Time.deltaTime);
			transform.eulerAngles = new Vector2 (0,0);
		}

		if (Input.GetKey(KeyCode.A)) {
			transform.Translate(Vector2.right * walkSpeed *Time.deltaTime);
			transform.eulerAngles = new Vector2 (0,180);
		}
	}


}
