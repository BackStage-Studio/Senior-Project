using UnityEngine;
using System.Collections;

public class cloud_orb : MonoBehaviour {

	public GameObject playerPos;
	public float moveSpeed;
	// Use this for initialization
	void Start () {
		playerPos = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay(Collider colli)
	{
		if(colli.gameObject.name==("Drain_Collision"))
		{
			//print("collect");
			Move ();
			//transform.position = new Vector3(0,0,0);
//			transform.position.x = Mathf.Lerp( transform.position.x,
//			                                   playerPos.transform.position.x, 
//			                                   Time.deltaTime * moveSpeed);
		}
	}
	private void Move()
	{
		transform.position = Vector3.Lerp (transform.position, playerPos.transform.position, moveSpeed*Time.deltaTime);
	}
}
