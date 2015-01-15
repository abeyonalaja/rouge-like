using UnityEngine;
using System.Collections;

public class Hero : MonoBehaviour {

	private float speed = 2.0f;

	private bool right = false;
	private bool left  = false;
	private bool up    = false;
	private bool down  = false;

	private Animator animator;

	public Rigidbody2D enemy;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		InvokeRepeating("EnemySpawn", 3, 3f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {
		MoveCharacter ();
	}

	void enemySpawn() {
		Rigidbody2D enemyInstance;

//		enemyInstance = Instantiate(enemy, transform.position, transform.rotation) as Rigidbody;
		enemyInstance = (Rigidbody2D) Instantiate(enemy,
		                            new Vector3(Random.Range(2, 8),Random.Range(-4, 4),0),
		                            Quaternion.Euler(new Vector3(0,0,0)));
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
