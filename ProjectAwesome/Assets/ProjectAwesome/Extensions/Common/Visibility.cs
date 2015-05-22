using UnityEngine;
using System.Collections;

/// <summary>
/// * 	The ProjectAwesome class is spread across multiple files
/// * 	This part provides GameObject extensions that allow the user to 
///		manipulate renderer visibility without using GetComponent
/// </summary>

//Author : Sam Legus
//Last Updated: 5/21/2015

//Vector2 class Documentation : http://docs.unity3d.com/ScriptReference/30_search.html?q=Vector2
//GameObject class Documentation: http://docs.unity3d.com/ScriptReference/GameObject.html
//Unity Extension Methods Tutorial: https://unity3d.com/learn/tutorials/modules/intermediate/scripting/extension-methods


public static partial class ProjectAwesome
{
	public static void ToggleVisibility(this GameObject gameObj)
	{
		Renderer ourRenderer = gameObj.GetComponent<Renderer>();
		if(ourRenderer != null)
		{
			bool isVisible = ourRenderer.enabled;
			ourRenderer.enabled = !isVisible;
		}
		else
		{
			Debug.Log (gameObj.name + " has no renderer component! Cannot toggle visibility");
		}
	}
	
	public static void Show(this GameObject gameObj)
	{
		Renderer ourRenderer = gameObj.GetComponent<Renderer>();
		if(ourRenderer != null)
		{
			ourRenderer.enabled = true;
		}
		else
		{
			Debug.Log (gameObj.name + " has no renderer component! Cannot enable visibility");
		}
	}
	
	public static void Hide(this GameObject gameObj)
	{
		Renderer ourRenderer = gameObj.GetComponent<Renderer>();
		if(ourRenderer != null)
		{
			ourRenderer.enabled = false;
		}
		else
		{
			Debug.Log (gameObj.name + " has no renderer component! Cannot disable visibility");
		}
	}
}