using UnityEngine;
using System.Collections;

public class kirbyMovement : MonoBehaviour {
	
	public float horizontal;
	public float speed = 1;
	public Vector2 velocidad;

	// Update is called once per frame
	void FixedUpdate () {

		horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		velocidad = new Vector2(horizontal,vertical);
		rigidbody2D.velocity = velocidad * speed;



	
	}
}
