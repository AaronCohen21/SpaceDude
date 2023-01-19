using UnityEngine;
using System.Collections;

public class MenuActions : MonoBehaviour {

	Player player;

	void Start() {
		player = GameObject.Find ("Player").GetComponent<Player> ();
	}


	public void MENU_ACTION_GotoPage(string sceneName) {
		Application.LoadLevel (sceneName);

	}

	public void light(float num) {
		player.jumpForce = num;
	}

	public void heavy(float num) {
		player.gravityScale = num;
	}
}
