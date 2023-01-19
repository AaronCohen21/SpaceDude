using UnityEngine;
using System.Collections;

public class WallSpikeAnim : MonoBehaviour {

	private bool hit2 = true;

	private bool hit3 = false;

	// Use this for initialization
	void Start () {
		hit2 = true;
		hit3 = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (hit2) {
			transform.Translate (Vector3.up * Time.deltaTime * 3);
		} else if (hit3) {
			transform.Translate (Vector3.down * Time.deltaTime * 3);
		}

		if (transform.position.y <= 2) {
			hit3 = false;
			hit2 = true;
		}
		if (transform.position.y >= 3) {
			hit3 = true;
			hit2 = false;
		}
	}
}
