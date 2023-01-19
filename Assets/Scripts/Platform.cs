using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {

	public float speed = 5f;

	public bool start = true;

	// Use this for initialization
	void Start () {
		start = true;
	}

	public void kStart() {
		start = false;
	}

	// Update is called once per frame
	void FixedUpdate () {
	
		if (GameObject.Find ("Master Switch").GetComponent<MasterSwich> ().active) {
			kStart ();
		}
		if (transform.position.x <= -40.33f) {
			Destroy (gameObject);
		}
		if (start) {
			transform.Translate (Vector3.left * Time.deltaTime * speed);
		}
	}
}
