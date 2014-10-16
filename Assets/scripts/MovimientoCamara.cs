using UnityEngine;
using System.Collections;

public class MovimientoCamara : MonoBehaviour {

	public Transform fantasma;
	private float posicionY;
	// Update is called once per frame
	void Update () 
	{
		this.MovimientoHorizontal();
		this.MovimientoVertical();

	}

	public void MovimientoHorizontal()
	{
		if ( fantasma.position.x > transform.position.x + 3 )  // si el fantasma esta cerca del centro de la camara la camara no se mueve
			transform.position = new Vector3(fantasma.position.x -3, transform.position.y,transform.position.z );
		if ( fantasma.position.x < transform.position.x - 3 )	// si el fantasma esta cerca del centro de la camara la camara no se mueve
			transform.position = new Vector3(fantasma.position.x +3, transform.position.y,transform.position.z );
	}

	public void MovimientoVertical()
	{
		if(fantasma.position.y > -3.1)
			transform.position = new Vector3(transform.position.x, fantasma.position.y , transform.position.z );
	}

}
