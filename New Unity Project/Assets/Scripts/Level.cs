using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public GameObject Generate(float distance) {
		GameObject obj = Instantiate(this.gameObject, new Vector2(distance, 0), transform.rotation);
		return obj;
	}
}
