using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour {

	public GameObject player;
	public GameObject DeadUI;

	//private float playerPos;
	// Use this for initialization
	void Start () {
		DeadUI.SetActive (false);
	}
	
	// Update is called once per frame
	void Update(){
		//if(followCharacter){
		followCam();
		//}
	}
	
	private void followCam(){
		//		float sigmaY = transform.position.y - player.transform.position.y;
		Vector3 playerPos;
		//		if (yFollow) {
		playerPos = new Vector3(player.transform.position.x,transform.position.y,transform.position.z);
		//		} else {
		//playerPos = new Vector3(player.transform.position.x,player.transform.position.y+sigmaY,transform.position.z);
		//		}
		transform.position = Vector3.Lerp (transform.position, playerPos, 1 * Time.deltaTime);
	}

	void OnCollisionEnter(Collision colli)
	{
		if (colli.gameObject.tag == "Player") {
			colli.gameObject.SetActive(false);
			DeadUI.SetActive (true);
		}
	}
	
}
