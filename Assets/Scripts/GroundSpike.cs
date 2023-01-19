using UnityEngine;
using System.Collections;

public class GroundSpike : MonoBehaviour {

	[SerializeField]
	private bool start = false;

	private float speed = 5f;

	// Use this for initialization
	void Start () {
		start = true;
	}
	
	// Update is called once per frame
	void Update() {
		if (start && transform.position.x <= -2.85) {
			start = false;
		}
	}

	void FixedUpdate () {
		if (start && transform.position.x >= -3.74)
		transform.Translate (Vector3.left * Time.deltaTime * speed);
	}
}
