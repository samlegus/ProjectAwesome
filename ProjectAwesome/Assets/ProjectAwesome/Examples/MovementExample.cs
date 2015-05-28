using UnityEngine;
using System.Collections;

public class MovementExample : MonoBehaviour 
{
	public GameObject target;
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.W))
		{
			gameObject.LookUp();
		}
		if(Input.GetKeyDown(KeyCode.S))
		{
			gameObject.LookDown();
		}
		if(Input.GetKeyDown(KeyCode.A))
		{
			gameObject.LookLeft ();
		}
		if(Input.GetKeyDown(KeyCode.D))
		{
			gameObject.LookRight();
		}
		
		if(Input.GetMouseButton(0))
		{
			gameObject.DisablePhysics ();
		}
		if(Input.GetMouseButtonDown(1))
		{
			gameObject.SetVelocityX(10);
		}
		if(Input.GetMouseButtonDown (2))
		{
			gameObject.EnablePhysics ();
		}
		
		//Debug.Log(GetComponent<Rigidbody2D>().velocity);
	}
}
