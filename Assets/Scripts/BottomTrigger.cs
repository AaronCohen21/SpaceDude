using UnityEngine;
using System.Collections;

public class BottomTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.name == "Player") {

			int num = Random.Range(1, 5);
			if (num == 1) {
				Instantiate (Resources.Load ("Bottom 1"));
			} else if (num == 2) {
				Instantiate (Resources.Load ("Bottom 2"));
			} else if (num == 3) {
				Instantiate (Resources.Load ("Mid 1"));
			} else if (num == 4) {
				Instantiate (Resources.Load ("Mid 2"));
			}

		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
