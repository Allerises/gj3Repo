using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loopdeloop : MonoBehaviour {
	private float timer = 0;

	void Start()
	{

	}

	void Update()
	{
		timer += Time.deltaTime;

		// To reset the timer

		if(timer > 28){
			
			timer = 0;
		}
	}
	}
