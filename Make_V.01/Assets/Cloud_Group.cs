using UnityEngine;
using System.Collections;

public class Cloud_Group : MonoBehaviour {

	//public GameObject[] clouds;
	public GameObject Tower;
	//public Transform up_posi;
	public Transform down_posi;

	public float downSpeed;

	public bool down;

	void Awake()
	{
//		for (int i=0; i<(transform.childCount); i++) {
//			print (i);
//			//clouds[i]=GameObject.Find("Cloud_Orb ("+i+")");
//		}
		//clouds
	}

	// Use this for initialization
	void Start () {
		//clouds = gameObject.GetComponentsInChildren(
		//print(transform.childCount);
//		for (int i=0; i<(transform.childCount); i++) {
//			print (i);
//			//clouds[i] = transform.GetChild(i).gameObject;
//		}
		//GameObject child1 = transform.GetChild(0);
		//print(child1.gameObject.name);
		//Example ();
//		GameObject child1 = transform.GetChild(0).gameObject;
//		print(child1.gameObject.name);
	}
	
	// Update is called once per frame
	void Update () {
		//if (clouds [0] == null) {
			
//		if(Input.GetKey(KeyCode.L)){
//			Destroy(clouds[0]);
//		}

//		if (!clouds [0].activeSelf) {
//			print("OK");
//		}
//		Tower.transform.position = Vector3.MoveTowards (up_posi.position, 
//		                                         down_posi.position, 
//		                                         downSpeed*Time.deltaTime);
		if (transform.childCount == 0) {
			down=true;
			print("OK");
		}
		if (down) {
			//Tower.SetActive(false);
			Tower.transform.position = Vector3.MoveTowards (Tower.transform.position, 
			                                                down_posi.position,
			     	                                         downSpeed*Time.deltaTime);
		}
//		if(Tower.transform.position.y!= down_posi.position.y)
//			Tower.transform.Translate(
	}
}
