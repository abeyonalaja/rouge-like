using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	private float enemySpeed;
	
	private bool enemyRight = false;
	private bool enemyLeft  = false;
	private bool enemyUp    = false;
	private bool enemyDown  = false;
	
	private Animator enemyAnimator;

	public GameObject hero;
	// Use this for initialization
	void Start () {
		enemySpeed = 1.0f;
		InvokeRepeating("Accelerate", 2, 5f);
	}
	
	// Update is called once per frame
	void Update () {
		EnemyMove ();
	}

	void EnemyMove() {
		hero = GameObject.Find ("hero");
		enemyAnimator = GetComponent<Animator> ();

		if(hero != null){

			if(transform.position.y > hero.transform.position.y){
				enemyAnimator.SetBool("enemyLeft",  false);
				enemyAnimator.SetBool("enemyUp",    false);
				enemyAnimator.SetBool("enemyDown",  true);
				enemyAnimator.SetBool("enemyRight", false);

				enemyDown  = true;
				enemyLeft  = false;
				enemyRight = false;
				enemyUp    = false;

				transform.Translate(Vector3.down * enemySpeed * Time.deltaTime);
			} 
			else
			{
				enemyAnimator.SetBool("enemyUp",    true);
				enemyAnimator.SetBool("enemyLeft",  false);
				enemyAnimator.SetBool("enemyRight", false);
				enemyAnimator.SetBool("enemyDown",  false);

				enemyUp    = true;
				enemyDown  = false;
				enemyLeft  = false;
				enemyRight = false;

				transform.Translate(Vector3.up * enemySpeed * Time.deltaTime);
			}

			if(transform.position.x < hero.transform.position.x){
				enemyAnimator.SetBool("enemyLeft", false);
				enemyAnimator.SetBool("enemyUp", false);
				enemyAnimator.SetBool("enemyDown", false);
				enemyAnimator.SetBool("enemyRight", true);

				enemyDown  = false;
				enemyLeft  = false;
				enemyRight = true;
				enemyUp    = false;

				transform.Translate(Vector3.right * enemySpeed * Time.deltaTime);
			}
			else
			{
				enemyAnimator.SetBool("enemyLeft", true);
				enemyAnimator.SetBool("enemyUp", false);
				enemyAnimator.SetBool("enemyDown", false);
				enemyAnimator.SetBool("enemyRight", false);

				enemyDown  = false;
				enemyLeft  = true;
				enemyRight = false;
				enemyUp    = false;

				transform.Translate(Vector3.left * enemySpeed * Time.deltaTime);
			}
		}
	}

	void Accelerate() {
		enemySpeed = enemySpeed + 1;
	}
}
