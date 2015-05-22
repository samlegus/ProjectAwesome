using UnityEngine;
using System.Collections;

/// <summary>
/// * 	The ProjectAwesome class is spread across multiple files
/// * 	This part provides simple physics manipulation without GetComponent calls
///		or the need to mess with Vector2s
/// </summary>

//Author : Sam Legus
//Last Updated: 5/21/2015

//Vector2 class Documentation : http://docs.unity3d.com/ScriptReference/30_search.html?q=Vector2
//GameObject class Documentation: http://docs.unity3d.com/ScriptReference/GameObject.html
//Rigidbody class Documentation: http://docs.unity3d.com/ScriptReference/Rigidbody2D.html
//Unity Extension Methods Tutorial: https://unity3d.com/learn/tutorials/modules/intermediate/scripting/extension-methods

public static partial class ProjectAwesome
{

	//Sets an object's velocity to zero.
	public static void ZeroVelocity(this GameObject gameObj)
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
	
	//Toggles the sleep mode of an object's Rigidbody2D
	public static void TogglePhysics2D(this GameObject gameObj)
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
	public static void DisablePhysics2D(this GameObject gameObj)
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
	public static void EnablePhysics2D(this GameObject gameObj)
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