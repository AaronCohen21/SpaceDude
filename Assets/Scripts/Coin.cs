using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	Player player;

	private BoxCollider2D playerCollider;

	private Animator anim;

	public int pointValue = 1;

	public bool collected = false;

	private bool getCoin = false;

	[SerializeField]
	private BoxCollider2D coinTrigger;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<Player> ();
		playerCollider = GameObject.Find ("Player").GetComponent<BoxCollider2D> ();
		anim = GetComponent<Animator> ();
		anim.SetBool ("collected", false);


	}
	void OnTriggerEnter2D(Collider2D other) {
		if ((other.gameObject.name == "Player" && !anim.GetBool ("collected")) && player.col) {
			GameObject.Destroy (gameObject);
			player.points += pointValue;

		}
	}
	// Update is called once per frame

	void FixedUpdate () {
	}
}
