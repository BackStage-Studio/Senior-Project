using UnityEngine;
using System.Collections;

public class cloud_orb : MonoBehaviour {

	//public GameObject player_colli;
	public float moveSpeed;

	private bool drain = false;
	private GameObject playerPos;
	private float spin;
	//private GameObject P_colli ;
	// Use this for initialization
	void Start () {
		//playerPos = GameObject.Find ("Player");
		//player_colli = GameObject.Find ("player");
		//player_colli = player_colli.GetComponentsInChildren<"Drain_Collision">();
		spin = Random.Range (-4.5f, 4.5f);
	}

	void FixedUpdate()
	{
		//playerPos = P_colli.gameObject;
		transform.Rotate(0, 0, spin);  
		if (drain) {
			Move ();
		}
		//drain = false;
	}
	// Update is called once per frame
	void Update () {
		
	}
	/*
	void OnTriggerStay(Collider colli)
	{
		if(colli.gameObject.name==("Drain_Collision"))
		{
			playerPos = colli.gameObject;
			//print("collect");
			Move ();
			//gameObject.SetActive(false);
			//transform.position = new Vector3(0,0,0);
//			transform.position.x = Mathf.Lerp( transform.position.x,
//			                                   playerPos.transform.position.x, 
//			                                   Time.deltaTime * moveSpeed);
			drain = true;
		}
		//if(colli==null)drain = false;
//		if (colli == player_colli) {
//			gameObject.SetActive(false);
//		}
	}
*/
	void OnTriggerEnter(Collider colli)
	{
		if(colli.gameObject.name==("Player")){
			//if(drain){
				//gameObject.SetActive(false);
				Destroy(gameObject);
				print ("Check");
			//}
		}
		if(colli.gameObject.name==("Drain_Collision"))
		{
			playerPos = colli.gameObject;
			//print("collect");
			//Move ();
			//gameObject.SetActive(false);
			//transform.position = new Vector3(0,0,0);
			//			transform.position.x = Mathf.Lerp( transform.position.x,
			//			                                   playerPos.transform.position.x, 
			//			                                   Time.deltaTime * moveSpeed);
			drain = true;
		}
//		if(colli.gameObject.name==("Player")){
//			gameObject.SetActive(false);
//			print ("Check");
//		}
	}


	private void Move()
	{
		transform.position = Vector3.MoveTowards(transform.position,playerPos.transform.position, moveSpeed*Time.deltaTime);
//		transform.position = Vector3.Lerp (transform.position, playerPos.transform.position, moveSpeed*Time.deltaTime);
//		if(((transform.position.x- playerPos.transform.position.x)<0.1)||((transform.position.y- playerPos.transform.position.y)<0.1))
//		{
//			Destroy(gameObject);
//		}
	}
}
