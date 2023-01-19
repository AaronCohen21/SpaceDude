using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public AudioSource hover;

	public bool col = true;

	public int points;

	private bool dAnim = false;

	private bool kplatforms = false;

	private bool activate = false;

	private bool alive = true;

	private Rigidbody2D myRigidbody;

	public Animator anim;

	private bool antiLag = true;

	public float jumpForce = 2f;

	public float gravityScale = 1f;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (transform.gameObject);
		col = true;
		anim.SetBool ("Dead", false);
		myRigidbody = GetComponent<Rigidbody2D>();
		dAnim = false;
		antiLag = true;
		activate = false;
		kplatforms = false;
	}
	private bool playing = false;

	void playerJump() {
		if (alive && (Input.GetKey (KeyCode.Space) || Input.GetKey (KeyCode.Mouse0) || Input.GetKey (KeyCode.Mouse1))) {

			transform.Translate (Vector3.up * Time.deltaTime * jumpForce);

			if (!playing && Application.loadedLevelName == ("Level")) {
				hover.Play ();
			}

			playing = true;

		} else if (alive && (!Input.GetKey (KeyCode.Space) || !Input.GetKey (KeyCode.Mouse0) || !Input.GetKey (KeyCode.Mouse1))) {

			transform.Translate (Vector3.down * Time.deltaTime * gravityScale);

			playing = false;

			hover.Pause ();
		}
	}

	public void killed() {
		col = false;
		GetComponent<BoxCollider2D> ().isTrigger = true;
		alive = false;
		anim.SetBool("Dead" , true);
		dAnim = true;
		kplatforms = true;
	}

	// Update is called once per frame
	public void MENU_ACTION_GotoPage(string sceneName) {
		Application.LoadLevel (sceneName);
	}
	void Update () {
		if (transform.position.y <= -9.26) {
			MENU_ACTION_GotoPage ("Death");
		}
	}

	void FixedUpdate () {
		playerJump ();
		if (dAnim) {
			if (anim.GetCurrentAnimatorStateInfo(0).IsName("Transition")) {
				transform.Translate (Vector3.down * Time.deltaTime * 8);
				activate = true;
			}
		}
		if (kplatforms) {
			GameObject.Find ("Master Switch").GetComponent<MasterSwich> ().initiate ();
		}
	}
}