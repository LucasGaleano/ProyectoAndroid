using UnityEngine;
using System.Collections;

public class CubeMovement : MonoBehaviour {
	
	public float speed;
	public Vector2 velocidad;
	public Vector2 rotacion;

	void FixedUpdate () 
	{
		
		
		Movimiento ();
		
	}
	
	
	public void Movimiento()
	{


		float speed = 20;
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		velocidad = new Vector2(horizontal , vertical);
		rigidbody.velocity = velocidad * speed;
		rotacion = new Vector2 (-vertical, horizontal);
		rigidbody.rotation = Quaternion.AngleAxis (-60, rotacion);

	}
}