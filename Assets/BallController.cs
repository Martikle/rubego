using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {


	Rigidbody rigid; 
	public TextMesh pressSpace;

	bool awake = false;

	// Use this for initialization
	void Start () {

		rigid = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space) && !awake) {

			Destroy (pressSpace);
			rigid.isKinematic = false;
			rigid.AddForce (transform.forward * 20, ForceMode.Impulse);
			awake = true;

		}
		
	}
}
