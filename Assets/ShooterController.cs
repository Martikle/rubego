﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterController : MonoBehaviour {

	public GameObject bullet;
	public int bulletsShot; 
	public float minbulletSpeed = -10;
	public float maxBulletSpeed = -100; 
	public int maxBullets = 500;
	public int timeAlive = 6;
	public bool triggered = false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (bulletsShot <= maxBullets && triggered) {
		//Debug.Log (bulletsShot);
		bulletsShot += 1;
		GameObject tempBullet = Instantiate (bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		tempBullet.GetComponent<Rigidbody> ().AddForce (transform.right * Random.Range(minbulletSpeed, maxBulletSpeed), ForceMode.Impulse);
		Destroy (tempBullet, timeAlive);
		//Destroy (tempBullet, 10);
		}
		
	}
}
