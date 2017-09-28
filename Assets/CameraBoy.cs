using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBoy : MonoBehaviour {

	public Transform lookAtTarget;
	public Transform moveToTarget;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.R)) {
			Application.LoadLevel(Application.loadedLevel);
		}

		if( lookAtTarget != null ) {
			transform.LookAt( lookAtTarget.position );

		if( moveToTarget != null ) {
			// first, we need to figure out what direction to move in?
			// calculate the vector from this transform (point A) to lookAtTarget (point B) = "B-A"
			Vector3 moveDirection = moveToTarget.position - transform.position;

			// is the magnitude greater than 1? if so, normalize it
			if( moveDirection.magnitude > 1f ) {
				// all 3 lines below do the same thing
				moveDirection = moveDirection / moveDirection.magnitude; // normalize
				moveDirection = moveDirection.normalized;
				moveDirection = Vector3.Normalize( moveDirection );
			}

			// actually move the camera a little now!
			transform.position += moveDirection * Time.deltaTime * 5f;

		}
		}
		
	}
}
