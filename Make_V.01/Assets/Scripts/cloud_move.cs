using UnityEngine;
using System.Collections;

public class cloud_move : MonoBehaviour {


	public float moveSpeed;

	private GameObject playerPos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay(Collider colli)
	{
		if (colli.gameObject.name == ("Move_Collision")) {
			playerPos = colli.gameObject;
			//print("collect");
			Move ();
		}
	}

	private void Move()
	{
		Vector3 pointToMove = new Vector3 (playerPos.transform.position.x, transform.position.y, transform.position.z);
		transform.position = Vector3.Lerp(transform.position,pointToMove, moveSpeed*Time.deltaTime);
	}
}
