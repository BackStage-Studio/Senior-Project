using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float walkSpeed = 10.0f;
	public float g = 10.0f;
	public GameObject drain_colli;

	//------------------------------BuJU------------------------------
	//Control
	public string jumpKey;
	
	//Functional
	public bool doubleJump;
	public bool wallCrash;
	public bool haveJump;
	
	
	//Attibute
	public float gravityPower;
	public float jumpPower;
	public int jumpStack;
	private float velocityY = 0;
	public bool isGround = false;
	private int jumpCount;
	
	//Debug
	public bool onDebug;
	//------------------------------------------------------------------

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
		gravity ();
	}
	void Update () {
		//PlayerMove ();
		//Movement ();
		DrainControl ();

		if(haveJump){
			if(doubleJump){
				jump2();
			}else{
				jump();
			}
		}

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

	//-------------------------------------BuJU-----------------------------------------------------------
	public void gravity()
	{
		RaycastHit hit;
		Vector3 footpos = new Vector3(transform.position.x,transform.position.y-(transform.localScale.y/2),transform.position.z);
		Vector3 footLeft = new Vector3(transform.position.x-(transform.localScale.x/2),transform.position.y-(transform.localScale.y/2),transform.position.z);
		Vector3 footRight = new Vector3(transform.position.x+(transform.localScale.x/2),transform.position.y-(transform.localScale.y/2),transform.position.z);
		
		if(onDebug){
			Debug.DrawRay(footpos,-Vector3.up,Color.red);
		}
		
		RaycastHit left,right;
		Physics.Raycast(footLeft,-Vector3.up,out left);
		Physics.Raycast(footRight,-Vector3.up,out right);
		if (Physics.Raycast (footpos, -Vector3.up, out hit)) {
			if (hit.distance < velocityY || right.distance < velocityY || left.distance < velocityY) {
				if (hit.distance < velocityY) {
					velocityY = hit.distance - 0.01f;
				} else if (left.distance < velocityY) {
					velocityY = left.distance - 0.01f;
				} else if (right.distance < velocityY) {
					velocityY = right.distance - 0.01f;
				}
				
				transform.position = new Vector3 (transform.position.x, transform.position.y - velocityY, transform.position.z);
				velocityY = 0;
				isGround = true;
				
				if (onDebug) {
					print ("last frame " + hit.distance);
				}
				
			} else if (isGround && Mathf.Round (hit.distance * 10) / 10 == 0) {
				jumpCount = jumpStack;
				velocityY = 0;
				
				if (onDebug) {
					print ("ground " + hit.distance);
				}
				
			} else if (Mathf.Round (left.distance * 10) / 10 != 0 && Mathf.Round (right.distance * 10) / 10 != 0) {
				isGround = false;
				velocityY += gravityPower;
				
				if (onDebug) {
					print ("float " + hit.distance);
				}	
			}
			
			if (wallCrash) {
				Vector3 headLeft = new Vector3 (transform.position.x - (transform.localScale.x / 2), transform.position.y + (transform.localScale.y / 2), transform.position.z);
				Vector3 headRight = new Vector3 (transform.position.x + (transform.localScale.x / 2), transform.position.y + (transform.localScale.y / 2), transform.position.z);
				RaycastHit hitLeft, hitRight;
				Physics.Raycast (headLeft, Vector3.up, out hitLeft);
				Physics.Raycast (headRight, Vector3.up, out hitRight);
				
				if (onDebug) {
					Debug.DrawRay (headLeft, Vector3.up, Color.red);
					Debug.DrawRay (headRight, Vector3.up, Color.red);
					print (hitLeft.distance + " : " + hitRight.distance);
				}
				
				if (hitLeft.distance != 0 || hitRight.distance != 0) {
					if ((hitLeft.distance < -velocityY || hitRight.distance < -velocityY) && (hitLeft.distance != 0 && hitRight.distance != 0)) {
						velocityY = 0;
					} else if ((hitLeft.distance == 0 && hitRight.distance != 0) && hitRight.distance < -velocityY) {
						velocityY = 0;
					} else if ((hitRight.distance == 0 && hitLeft.distance != 0) && hitLeft.distance < -velocityY) {
						velocityY = 0;
					}
					
				}
			}
			
			if (!isGround) {
				transform.position = new Vector3 (transform.position.x, transform.position.y - velocityY, transform.position.z);
			}
			
		} else {
			velocityY += 0.001f;
			transform.position = new Vector3 (transform.position.x, transform.position.y + velocityY, transform.position.z);
		}
	}

	private void jump(){
		if(Input.GetKeyDown(jumpKey)){
			if(isGround){
				velocityY = -jumpPower;
				isGround = false;
			}
		}
	}
	
	private void jump2(){
		if(Input.GetKeyDown(jumpKey) && jumpCount > 0){
			velocityY = -jumpPower;
			isGround = false;
			jumpCount--;
		}
	}
	//----------------------------------------------------------------------------------------------------------------

}
