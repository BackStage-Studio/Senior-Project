using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float walkSpeed = 10.0f;
	public float g = 10.0f;
	public GameObject drain_colli;

	private int mainSpeed = 100;
	private GameObject PlayerChar ;
	// Use this for initialization
	void Start () {
		//PlayerChar = GetComponent<this.gameObject>();
		drain_colli.SetActive (false);
	}
	
	void FixedUpdate(){
		//PlayerMove ();
		Movement ();
	}
	void Update () {
		//PlayerMove ();
		//Movement ();
		DrainControl ();

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

	private void DrainControl()
	{
		if (Input.GetKey (KeyCode.E)) {
			drain_colli.SetActive (true);
		}
		else{
			drain_colli.SetActive (false);
		}
	}


}
