using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {

	Player player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindObjectOfType<Player> ();
		Destroy (player.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
