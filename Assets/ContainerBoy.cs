using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerBoy : MonoBehaviour {

	public ShooterController shooter;
	public BoxCollider box;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision coll) {

		shooter.triggered = true;


	}
}
