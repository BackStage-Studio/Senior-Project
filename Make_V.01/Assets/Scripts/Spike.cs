using UnityEngine;
using System.Collections;

public class Spike : MonoBehaviour {


	public GameObject DeadUI;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision colli)
	{
		if (colli.gameObject.tag == "Player") {
			colli.gameObject.SetActive(false);
			DeadUI.SetActive (true);
		}
	}
}
