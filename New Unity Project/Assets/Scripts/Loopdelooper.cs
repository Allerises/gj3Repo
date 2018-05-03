using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loopdelooper : MonoBehaviour {
	public float timer = 0;
	void Start()
	{

	}

	void Update()
	{
		timer += Time.deltaTime;

		// To reset the timer

		if(timer > 63){
			transform.position += Vector3.right * 284.0f;
			timer = 0;
		}
	}
}
