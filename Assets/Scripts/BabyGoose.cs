﻿using UnityEngine;
using System.Collections;

public class BabyGoose : MonoBehaviour {

	public Transform LevelManager;
	public Transform explosionPrefab;
	public float followSharpness = 0.1f;

	Vector3 _followOffset;

	void Start()
	{
	}

	void LateUpdate () 
	{
		gameObject.transform.position = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, 0);
	}

	void OnCollisionEnter2D(Collision2D coll)  {
		// Do a gameover
		Debug.Log("Game Over!");
		gameObject.GetComponentInParent<SnakeMovement> ().bodyParts.Remove (gameObject.transform);
		Instantiate (explosionPrefab, gameObject.transform.position, Quaternion.identity);
		Destroy (gameObject);
	}
}
