using UnityEngine;
using System.Collections;

public class Absorb : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider colli)
	{
		if(colli.gameObject.tag==("cloud_orb"))
		{
			print("collect");
		}
	}
}
