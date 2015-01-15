using UnityEngine;
using System.Collections;

public class Hero : MonoBehaviour {

	private float speed = 2.0f;

	private bool right = false;
	private bool left  = false;
	private bool up    = false;
	private bool down  = false;

	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {
		MoveCharacter ();
	}

	void MoveCharacter() {
		if(Input.GetKey (KeyCode.D)){
			animator.SetBool("right", true);

			animator.SetBool("left",  false);
			animator.SetBool("up",    false);
			animator.SetBool("down",  false);

			right = true;

			down  = false;
			left  = false;
			up    = false;

			transform.Translate (Vector3.right * speed * Time.deltaTime);
		}

		if (right == true) {
			transform.Translate(Vector3.right * speed * Time.deltaTime);
		}
		
		if(left == true){
			transform.Translate(Vector3.left * speed * Time.deltaTime);
		}
		
		if (up == true) {
			transform.Translate(Vector3.up * speed * Time.deltaTime);
		}
		
		if (down == true) {
			transform.Translate (Vector3.down * speed * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.A)){
			animator.SetBool("left",  true);

			animator.SetBool("right", false);
			animator.SetBool("up",    false);
			animator.SetBool("down",  false);

			left  = true;

			down  = false;
			right = false;
			up    = false;
			transform.Translate(Vector3.left * speed * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.W)) {
			animator.SetBool("up",    true);

			animator.SetBool("left",  false);
			animator.SetBool("right", false);
			animator.SetBool("down",  false);

			up    = true;

			left  = false;
			right = false;
			down  = false;
			transform.Translate(Vector3.up * speed * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.S)){
			animator.SetBool("left",  false);
			animator.SetBool("right", false);
			animator.SetBool("up",    false);
			animator.SetBool("down",  true);

			down = true;

			left  = false;
			right = false;
			up    = false;
			transform.Translate(Vector3.down * speed * Time.deltaTime);
		}


	}
}
