using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;

public class AwesomeScriptMenuOption
{
	[MenuItem("Assets/Create/Awesome Script")]
	private static void CreateNewAwesomeScript()
	{
		string newFilePath = EditorUtility.SaveFilePanelInProject(	"Create new AwesomeScript",
		                                                       		"NewAwesomeScript" + ".cs",
		                                              				"cs",
																	"Choose name and save location for NewAwesomeScript");

		
//		var selectedObject = Selection.activeObject;
//		string objectFilePath = AssetDatabase.GetAssetPath (selectedObject.GetInstanceID());
//		
//		if(objectFilePath.Length > 0)
//		{
//			if(Directory.Exists (objectFilePath))
//			{
//				//Then we're selecting an asset and not a folder
//				//Create the new script in the assets containing folder
//				Debug.Log ("Folder selected!");
//			}
//		}
		
		string sourceFilePath = Application.dataPath + "/ProjectAwesome/AwesomeScript/AwesomeScriptTemplate.cs";
		
		Debug.Log(newFilePath);
		Debug.Log (sourceFilePath);
		
		File.Copy (sourceFilePath, newFilePath);
		
		string tempFilePath = Application.dataPath + "/ProjectAwesome/AwesomeScript/AwesomeTemp.cs";
		
		StreamReader sr = new StreamReader(newFilePath);
		StreamWriter sw = new StreamWriter(tempFilePath);
		
		string line;
		while((line = sr.ReadLine()) != null)
		{
			if(line.Contains ("public class AwesomeScriptTemplate"))
			{
				string newClassName = Path.GetFileNameWithoutExtension (newFilePath);
				Debug.Log (newClassName);
				sw.WriteLine("public class " + newClassName + " : AwesomeScript");
			}
			else
			{
				sw.WriteLine (line);
			}
		}
		
		sw.Close ();
		sr.Close ();
		
		File.Copy (tempFilePath, newFilePath, true);
		File.Delete (tempFilePath);
							
																																																					
		AssetDatabase.Refresh ();
	}
}

public static class StringExtensions
{
	//Move this later
	public static string ReplaceFirst(this string text, string search, string replace)
	{
		int pos = text.IndexOf(search);
		if (pos < 0)
		{
			return text;
		}
		return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
	}
}