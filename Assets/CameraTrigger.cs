using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour {

	public Transform lookOverride;
	public Transform moveOverride;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider activator) {

		Debug.Log(this.name + " got triggered by " + activator.name);

		// find the CameraControl script by accessing Main Camera, and then GetComponent on it
		CameraBoy camControl = Camera.main.GetComponent<CameraBoy>();

		// override CameraControl values with this trigger's values
		if( lookOverride != null ) { // for more on "null", see CameraControl.cs script
			camControl.lookAtTarget = lookOverride;
		}

		if( moveOverride != null ) {
			camControl.moveToTarget = moveOverride;
		}

		Destroy (this);
	}
}
