using UnityEngine;
using System.Collections;

public class Spikes : MonoBehaviour {

	public Player _player;

	private BoxCollider2D playerCollider;

	[SerializeField]
	private BoxCollider2D spikeTrigger;

	void Update() {
		
	}

	// Use this for initialization
	void Start () {
		playerCollider = GameObject.Find ("Player").GetComponent<BoxCollider2D> ();
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.name == "Player") {
			//kill the player here
			GameObject.Find ("Player").GetComponent<Player>().killed();
		}
	}
}
