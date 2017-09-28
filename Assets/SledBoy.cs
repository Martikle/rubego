using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SledBoy : MonoBehaviour {

	public ShooterController shooter;
	Rigidbody rigid;
	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (shooter.bulletsShot >= 150) {
			rigid.isKinematic = false;

		}

	}
}
