using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncerBoy : MonoBehaviour {

	public ShooterController shooter1;
	public ShooterController shooter2;
	public ShooterController shooter3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter(Collision coll) {

		shooter1.triggered = true;
		shooter2.triggered = true;
		shooter3.triggered = true;


	}
}
