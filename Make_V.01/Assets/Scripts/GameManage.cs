using UnityEngine;
using System.Collections;

public class GameManage : MonoBehaviour {
	public GameObject DeadUI;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Restart ();
		
	}

	public void Restart()
	{
		if (DeadUI.activeSelf) {
			if (Input.GetKey (KeyCode.R)) {
				//if(DeadUI.activeSelf)
				Application.LoadLevel (0);
			}
		}
	}
}
