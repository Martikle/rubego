using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinaleContainer : MonoBehaviour {


	BoxCollider coll;
	public ShooterController shooter;
	public int num;
	public bool itsTIME = false;
	bool collided = false;


	// Use this for initialization
	void Start () {
	
		coll = GetComponent<BoxCollider> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (shooter.bulletsShot >= shooter.maxBullets)
			itsTIME = true;

		if (itsTIME) {


		}

		
	}

	void OnCollisionEnter(Collision collider) {

		if (!collided) {
			num++;
			//collider.collided = true;
			Destroy (collider.gameObject, 3);
		}
	}
}
