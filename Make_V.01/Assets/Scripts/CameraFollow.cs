using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

//	public Transform Player;
//	public float followSpeed = 5.0f;
//	
//	void Start () {
//		
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		//transform.position = new Vector3 (Player.position.x, transform.position.y, transform.position.z);
//		transform.position = Vector3.Lerp(transform.position, Player.position+transform.position, followSpeed);
//	}

	//public bool followCharacter;
	//public bool yFollow;
	public GameObject player;
	public float camSpeed;
	
	private float fixedSigmaY;
	
	void Start(){
		fixedSigmaY = transform.position.y - player.transform.position.y;
	}
	
	void Update(){
		//if(followCharacter){
			followCam();
		//}
	}
	
	private void followCam(){
		float sigmaY = transform.position.y - player.transform.position.y;
		Vector3 playerPos;
//		if (yFollow) {
//			playerPos = new Vector3(player.transform.position.x,player.transform.position.y+fixedSigmaY,transform.position.z);
//		} else {
			playerPos = new Vector3(player.transform.position.x,player.transform.position.y+sigmaY,transform.position.z);
//		}
		transform.position = Vector3.Lerp (transform.position, playerPos, camSpeed);
	}
}
