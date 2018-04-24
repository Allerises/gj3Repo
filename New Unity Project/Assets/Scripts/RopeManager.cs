using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeManager : MonoBehaviour {

    public GameObject rope;
    private Transform ropeT;
    private HingeJoint ropeS;

	// Use this for initialization
	void Start () {
        ropeT = rope.GetComponent<Transform>();
        ropeS = rope.GetComponent<HingeJoint>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
