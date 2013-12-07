using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	public float speed;
	void Update()
	{

	}
	void FixedUpdate()
	{
		float movehorizontal = Input.GetAxis("Horizontal");
		float movevertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (movehorizontal, 0.0f, movevertical);
		rigidbody.AddForce (movement * speed * Time.deltaTime);
	}
}