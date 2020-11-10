using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class Pause : MonoBehaviour 
{

	#region Attributs

	private bool isPaused = false;

	#endregion
	
	#region Methodes
	
	void Start () 
	{
	
	}
	
	
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Escape))
			isPaused = !isPaused;


		if(isPaused)
			Time.timeScale = 0f;
		
		else
			Time.timeScale = 1.0f;


	}

	void OnGUI ()
	{
		if(isPaused)
		{
		
			if(GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2 - 20, 80, 40), "Continuer"))
			{
				isPaused = false;
			}

            if(GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2 + 10, 80, 40), "Options"))
			{
				Application.LoadLevel("Options");
			}

			if(GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2 + 40, 80, 40), "Quitter"))
			{
				Application.LoadLevel("Menu Principal"); 
			}

		}
	}
	
	#endregion
}
