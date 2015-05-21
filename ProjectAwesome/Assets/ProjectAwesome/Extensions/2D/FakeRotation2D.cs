using UnityEngine;
using System.Collections;

/// <summary>
/// Project awesome is spread across multiple files, this part of the class allows
/// for fake "rotations" by inverting the x and y values of an objects scale.
/// For "real" rotations , see Rotation.cs.
/// Do not use real and fake rotations together.
/// </summary>

//Author : Sam Legus
//Last Updated: 5/21/2015

//Vector2 class Documentation : http://docs.unity3d.com/ScriptReference/30_search.html?q=Vector2
//GameObject class Documentation: http://docs.unity3d.com/ScriptReference/GameObject.html
//Unity Extension Methods Tutorial: https://unity3d.com/learn/tutorials/modules/intermediate/scripting/extension-methods


public static partial class ProjectAwesome
{
	public static void FlipHorizontal(this GameObject gameObj)
	{
		Vector2 originalScale = gameObj.transform.localScale;
		Vector2 flippedScale = new Vector2(originalScale.x * -1f, originalScale.y);
		
		gameObj.transform.localScale = flippedScale;
	}
	
	public static void FlipVertical(this GameObject gameObj)
	{
		Vector2 originalScale = gameObj.transform.localScale;
		Vector2 flippedScale = new Vector2(originalScale.x , originalScale.y * -1f);
		
		gameObj.transform.localScale = flippedScale;
	}
	
	public static void LookLeft(this GameObject gameObj)
	{
		Vector2 originalScale = gameObj.transform.localScale;
		Vector2 faceLeftScale = new Vector2( Mathf.Abs(originalScale.x) * -1, originalScale.y);
		
		gameObj.transform.localScale = faceLeftScale;
	}
	
	public static void LookRight(this GameObject gameObj)
	{
		Vector2 originalScale = gameObj.transform.localScale;
		Vector2 faceLeftScale = new Vector2( Mathf.Abs(originalScale.x), originalScale.y);
		
		gameObj.transform.localScale = faceLeftScale;  
	}
	
	public static void LookUp(this GameObject gameObj)
	{
		Vector2 originalScale = gameObj.transform.localScale;
		Vector2 faceLeftScale = new Vector2( originalScale.x, Mathf.Abs (originalScale.y));
		
		gameObj.transform.localScale = faceLeftScale;
	}
	
	public static void LookDown(this GameObject gameObj)
	{
		Vector2 originalScale = gameObj.transform.localScale;
		Vector2 faceLeftScale = new Vector2(originalScale.x, Mathf.Abs (originalScale.y) * -1f);
		
		gameObj.transform.localScale = faceLeftScale;
	}
}