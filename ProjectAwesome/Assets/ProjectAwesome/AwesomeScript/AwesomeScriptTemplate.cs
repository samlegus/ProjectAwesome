using UnityEngine;
using System.Collections;

public class AwesomeScriptTemplate : AwesomeScript 
{
	//Put variables that you want to set from the inspector inside this region
	#region Inspector Variables
	
	#endregion
	
	//Put variables that you do not want to set from the inspector inside this region
	#region Private Variables
	
	#endregion
	
	//All functions inside this region are automatically called by Unity
	#region Unity Events
	
	//Any code written inside of Start will be called once when the object is created.
	void Start()
	{
	
	}
	
	//Any code written instead of Update will be called every time the application updates
	void Update()
	{
		Debug.Log ("Hello World!");
	}
	
	//Any code written inside of OnCollisionEnter2D will be called when this 2D object collides with another
	void OnCollisionEnter2D(Collision2D other)
	{
		Debug.Log (self.name + " collided with " + other.gameObject.name + "!");
	}
	
	#endregion
	
	//Put any functions that you write yourself inside this region
	#region My Functions
	
	#endregion
}
