using UnityEngine;
using System.Collections;

public class MasterSwich : MonoBehaviour {

	public bool active = false;

	// Use this for initialization
	void Start () {

		active = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

	public void initiate() {
		active = true;
	}
}
