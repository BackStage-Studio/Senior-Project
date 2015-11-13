using UnityEngine;
using System.Collections;

public class Dead_Smoke : MonoBehaviour {

	public GameObject Player;
	public GameObject Boom;
	// Use this for initialization
	void Start () {
		Boom.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3 (Player.transform.position.x, Player.transform.position.y, Player.transform.position.z);
		if (Player.activeSelf == false) {
			Boom.SetActive (true);
		}
	}
}
