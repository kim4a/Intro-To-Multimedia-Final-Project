﻿// by @torahhorse

// Instructions:
// Place on player. OnBelowLevel will get called if the player ever falls below

using UnityEngine;
using System.Collections;

public class CheckIfBelowLevel : MonoBehaviour
{
	public float resetBelowThisY = -100f;
	
	private Vector3 startingPosition;
	
	void Awake()
	{
		startingPosition = transform.position;
	}
	
	void Update ()
	{
		if( transform.position.y < resetBelowThisY )
		{
			OnBelowLevel();
		}
	}
	
	private void OnBelowLevel()
	{
		Debug.Log("Player fell below level");
	
		// reset the player
		transform.position = startingPosition;
		
		// alternatively, you could just reload the current scene using this line:
		//Application.LoadLevel(Application.loadedLevel);
	}
}
