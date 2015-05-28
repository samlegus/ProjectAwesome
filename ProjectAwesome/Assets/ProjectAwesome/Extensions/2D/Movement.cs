using UnityEngine;
using System.Collections;

/// <summary>
/// * 	The ProjectAwesome class is spread across multiple files
/// * 	This part provides GameObject extensions that allow (non-physics driven) movement
///		without the use of GetComponent or Vector2s (overloads for Vector2s are provided in some cases)
/// </summary>

//Author : Sam Legus
//Last Updated: 5/28/2015

//Vector2 class Documentation : http://docs.unity3d.com/ScriptReference/30_search.html?q=Vector2
//GameObject class Documentation: http://docs.unity3d.com/ScriptReference/GameObject.html
//Unity Extension Methods Tutorial: https://unity3d.com/learn/tutorials/modules/intermediate/scripting/extension-methods


public static partial class ProjectAwesome
{
	//the "this GameObject gameObj" is a required paramater for making extensions, it does not show up when an extension method is called
	//example : the Move function would be called like Move(1f, 2f) - the this GameObject paramater is hidden/ignored
	
	//Standard raw movement, effectively replaces transform.translate
	public static void Move(this GameObject gameObj, float x, float y)
	{
		Vector2 translation = new Vector2(x, y) * Time.deltaTime;
		gameObj.transform.Translate ( translation );
	}	
	
	//Raw movement function that will move the source gameObject towards another gameObject
	public static void MoveToward(this GameObject gameObj, GameObject target, float speed)
	{
		Vector2 ourPosition = gameObj.transform.position;
		Vector2 targetPosition = target.transform.position;
		Vector2 newPosition = Vector2.MoveTowards ( ourPosition, targetPosition, speed * Time.deltaTime );
		
		gameObj.transform.position = newPosition;
	}
	
	//Overloaded version of MoveToward that takes two floats instead of a gameObject or a Vector2
	public static void MoveToward(this GameObject gameObj, float x, float y, float speed)
	{
		Vector2 ourPosition = gameObj.transform.position;
		Vector2 targetPosition = new Vector2(x,y);
		Vector2 newPosition = Vector2.MoveTowards ( ourPosition, targetPosition, speed * Time.deltaTime );
		
		gameObj.transform.position = newPosition;
	}
	
	//Overloaded version of MoveToward that takes a Vector2 instead of a game object
	public static void MoveToward(this GameObject gameObj, Vector2 targetPosition, float speed)
	{
		Vector2 ourPosition = gameObj.transform.position;
		Vector2 newPosition = Vector2.MoveTowards ( ourPosition, targetPosition, speed * Time.deltaTime );
		
		gameObj.transform.position = newPosition;
	}
	
	/*
	
	//Finish later
	//Smooth movement function
	public static void MoveOverTime(this GameObject gameObj, float x, float y, float seconds)
	{
		Vector2 ourPosition = gameObj.transform.position;
		Vector2 finalPosition = new Vector2 (x, y);
		Vector2 nextPosition = Vector2.Lerp (ourPosition, finalPosition, seconds * Time.deltaTime);
		
		gameObj.transform.position = nextPosition;
	}
	
	*/

	
	public static void SetPosition(this GameObject gameObj, float x, float y)
	{
		gameObj.transform.position = new Vector2(x,y);
	}
	
	public static void SetPositionX(this GameObject gameObj, float x)
	{
		gameObj.transform.position = new Vector2(x, gameObj.transform.position.y);
	}
	
	public static void SetPositionY(this GameObject gameObj, float y)
	{
		gameObj.transform.position = new Vector2(gameObj.transform.position.x, y);
	}
	
	/*
	
	//Don't want this coming up in the auto complete drop down and confusing newbies.
	
	public static Vector2 GetPosition(this GameObject gameObj)
	{
		return gameObj.transform.position;
	}
	
	*/
	
	
	public static float GetPositionX(this GameObject gameObj)
	{
		return gameObj.transform.position.x;
	}
	
	public static float GetPositionY(this GameObject gameObj)
	{
		return gameObj.transform.position.y;
	}
}
