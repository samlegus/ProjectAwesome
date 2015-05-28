using UnityEngine;
using System.Collections;

/// <summary>
/// * 	The ProjectAwesome class is spread across multiple files
/// * 	This part provides simple physics manipulation without GetComponent calls
///		or the need to mess with Vector2s
/// * 	Even though it is widely considered improper, these functions directly modify the velocity of
///		an object's Rigidbody2D instead of using AddForce for the sake of simplicity
/// </summary>

//Author : Sam Legus
//Last Updated: 5/28/2015

//Vector2 class Documentation : http://docs.unity3d.com/ScriptReference/30_search.html?q=Vector2
//GameObject class Documentation: http://docs.unity3d.com/ScriptReference/GameObject.html
//Rigidbody class Documentation: http://docs.unity3d.com/ScriptReference/Rigidbody2D.html
//Unity Extension Methods Tutorial: https://unity3d.com/learn/tutorials/modules/intermediate/scripting/extension-methods

public static partial class ProjectAwesome
{

	//Sets an object's velocity to zero.
	public static void StopMotion(this GameObject gameObj)
	{
		Rigidbody2D ourRigidbody = gameObj.GetComponent<Rigidbody2D>();
		if(ourRigidbody != null)
		{
			ourRigidbody.velocity = Vector2.zero;
		}
		else
		{
			Debug.Log (gameObj.name + " has no Rigidbody2D component! Velocity not accessible.");
		}
	}
	
	//Sets an object's velocity using two floats
	public static void SetVelocity(this GameObject gameObj, float x, float y)
	{
		Rigidbody2D ourRigidbody = gameObj.GetComponent<Rigidbody2D>();
		if(ourRigidbody != null)
		{
			Vector2 newVelocity = new Vector2(x,y);
			ourRigidbody.velocity = newVelocity;
		}
		else
		{
			Debug.Log (gameObj.name + " has no Rigidbody2D component! Velocity not accessible.");
		}
	}
	
	//Sets an object's velocity using a Vector2
	public static void SetVelocity(this GameObject gameObj, Vector2 newVelocity)
	{
		Rigidbody2D ourRigidbody = gameObj.GetComponent<Rigidbody2D>();
		if(ourRigidbody != null)
		{
			ourRigidbody.velocity = newVelocity;
		}
		else
		{
			Debug.Log (gameObj.name + " has no Rigidbody2D component! Velocity not accessible.");
		}
	}
	
	//Sets an objects horizontal velocity
	public static void SetVelocityX(this GameObject gameObj, float x)
	{
		Rigidbody2D ourRigidbody = gameObj.GetComponent<Rigidbody2D>();
		if(ourRigidbody != null)
		{
			Vector2 oldVelocity = ourRigidbody.velocity;
			Vector2 newVelocity = new Vector2(x, oldVelocity.y);
			ourRigidbody.velocity = newVelocity;
		}
		else
		{
			Debug.Log (gameObj.name + " has no Rigidbody2D component! Velocity not accessible.");
		}
	}
	
	//Sets an objects vertical velocity
	public static void SetVelocityY(this GameObject gameObj, float y)
	{
		Rigidbody2D ourRigidbody = gameObj.GetComponent<Rigidbody2D>();
		if(ourRigidbody != null)
		{
			Vector2 oldVelocity = ourRigidbody.velocity;
			Vector2 newVelocity = new Vector2(oldVelocity.x, y);
			ourRigidbody.velocity = newVelocity;
		}
		else
		{
			Debug.Log (gameObj.name + " has no Rigidbody2D component! Velocity not accessible.");
		}
	}
	
	public static float GetDirectionX(this GameObject gameObj)
	{
		Rigidbody2D ourRigidbody = gameObj.GetComponent<Rigidbody2D>();
		if(ourRigidbody != null)
		{
			return ourRigidbody.velocity.normalized.x;
		}
		else
		{
			Debug.Log (gameObj.name + " has no Rigidbody2D component! Velocity not accessible.");
			return 0f;
		}
	}
	
	public static float GetDirectionY(this GameObject gameObj)
	{
		Rigidbody2D ourRigidbody = gameObj.GetComponent<Rigidbody2D>();
		if(ourRigidbody != null)
		{
			return ourRigidbody.velocity.normalized.y;
		}
		else
		{
			Debug.Log (gameObj.name + " has no Rigidbody2D component! Velocity not accessible.");
			return 0f;
		}
	}
	
	public static Vector2 GetDirection(this GameObject gameObj)
	{
		Rigidbody2D ourRigidbody = gameObj.GetComponent<Rigidbody2D>();
		if(ourRigidbody != null)
		{
			return ourRigidbody.velocity.normalized;
		}
		else
		{
			Debug.Log (gameObj.name + " has no Rigidbody2D component! Velocity not accessible.");
			return Vector2.zero;
		}
	}
	/*
	//Returns the x velocity of an object
	public static float GetVelocityX(this GameObject gameObj)
	{
		Rigidbody2D ourRigidbody = gameObj.GetComponent<Rigidbody2D>();
		if(ourRigidbody != null)
		{
			return ourRigidbody.velocity.x;
		}
		else
		{
			Debug.Log (gameObj.name + " has no Rigidbody2D component! Velocity not accessible.");
			return 0f;
		}
	}
	
	//Returns the the y velocity of an object
	public static float GetVelocityY(this GameObject gameObj)
	{
		Rigidbody2D ourRigidbody = gameObj.GetComponent<Rigidbody2D>();
		if(ourRigidbody != null)
		{
			return ourRigidbody.velocity.y;
		}
		else
		{
			Debug.Log (gameObj.name + " has no Rigidbody2D component! Velocity not accessible.");
			return 0f;
		}
	}
	/*
	
	//Returns the velocity of an object
	public static float GetVelocity(this GameObject gameObj)
	{
		Rigidbody2D ourRigidbody = gameObj.GetComponent<Rigidbody2D>();
		if(ourRigidbody != null)
		{
			return ourRigidbody.velocity;
		}
		else
		{
			return Vector2.zero;
			Debug.Log (gameObj.name + " has no Rigidbody2D component! Velocity not accessible.");
		}
	}
	*/
	
	
	//Toggles the sleep mode of an object's Rigidbody2D
	public static void TogglePhysics(this GameObject gameObj)
	{
		Rigidbody2D ourRigidbody = gameObj.GetComponent<Rigidbody2D>();
		if(ourRigidbody != null)
		{
			if( ourRigidbody.IsSleeping () == false)
			{
				ourRigidbody.Sleep ();
			}
			else
			{
				ourRigidbody.WakeUp ();
			}
		}
		else
		{
			Debug.Log (gameObj.name + " has no Rigidbody2D component! Cannot disable physics.");
		}
	}
	
	//Puts the object's Rigidbody2D to sleep
	public static void DisablePhysics(this GameObject gameObj)
	{
		Rigidbody2D ourRigidbody = gameObj.GetComponent<Rigidbody2D>();
		if(ourRigidbody != null)
		{
			ourRigidbody.Sleep ();
		}
		else
		{
			Debug.Log (gameObj.name + " has no Rigidbody2D component! Cannot disable physics.");
		}
		
	}
	
	//Wakes up an object's Rigidbody2D
	public static void EnablePhysics(this GameObject gameObj)
	{
		Rigidbody2D ourRigidbody = gameObj.GetComponent<Rigidbody2D>();
		if(ourRigidbody != null)
		{
			ourRigidbody.WakeUp ();
		}
		else
		{
			Debug.Log (gameObj.name + " has no Rigidbody2D component! Cannot enable physics.");
		}
	}
	
}