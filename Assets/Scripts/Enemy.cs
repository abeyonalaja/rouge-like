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

			}
		}
	}
}
