using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinaleShooter : MonoBehaviour {

	public FinaleContainer finaleContainer;
	public GameObject bullet;
	public int bulletsShot; 
	public float minbulletSpeed = -10;
	public float maxBulletSpeed = -100; 
	public int maxBullets;


	// Use this for initialization
	void Start () {

		finaleContainer = transform.parent.GetComponent<FinaleContainer>();
		//maxBullets = finaleContainer.num;

	}
	
	// Update is called once per frame
	void Update () {

		if (bulletsShot <= maxBullets && finaleContainer.itsTIME) {
			maxBullets = finaleContainer.num * 5;
			//Debug.Log (bulletsShot);
			bulletsShot += 1;
			GameObject tempBullet = Instantiate (bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			tempBullet.GetComponent<Rigidbody> ().AddForce (transform.right * Random.Range(minbulletSpeed, maxBulletSpeed), ForceMode.Impulse);
			//Destroy (tempBullet, 10);
		}
		
	}
}
