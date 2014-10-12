using UnityEngine;
using System.Collections;

public class HombreMovement : MonoBehaviour {

	public float velocidad;
	bool facingright = true;
	Animator anim ; //= new Animator ();

	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;

	void Update () 
	{
		grounded = Physics2D.OverlapCircle (groundCheck.position,groundRadius,whatIsGround);
		anim.SetBool ("Ground",grounded);
		anim.SetFloat ("velocidadVertical",rigidbody2D.velocity.y);

		if(grounded && Input.GetKeyDown (KeyCode.Space))
	    {
			anim.SetBool ("Ground",false);
			rigidbody2D.AddForce (new Vector2 (0, 700));

		}




		float horizontal = Input.GetAxis ("Horizontal");
		//bool saltar = Input.GetButtonDown ("Jump");

		velocidad = 10;
		/*
		if (saltar == true) 
		{
			rigidbody2D.AddForce (new Vector2 (0, 700));
		}
		*/
		anim.SetFloat ("horizontal", Mathf.Abs (horizontal));

		rigidbody2D.velocity = new Vector2(horizontal * velocidad , rigidbody2D.velocity.y);

		if (horizontal > 0 && !facingright || horizontal < 0 && facingright )
			Flip ();

	}



	void Flip()
	{
		facingright = !facingright;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;

	}

	void Start()
	{
		anim = GetComponent<Animator>();
	}
}


