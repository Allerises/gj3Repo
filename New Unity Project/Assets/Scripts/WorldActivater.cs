using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldActivater : MonoBehaviour {
	
	int number;

	public GameObject SnowWorld;
	public GameObject GrassWorld;
	public GameObject DesertWorld;

    private GameObject activatedWorld;

	// Use this for initialization
	void Start () {

       
	}

    public void generateNewWorld(){
        SnowWorld.SetActive(false);
        GrassWorld.SetActive(false);
        DesertWorld.SetActive(false);

        number = Random.Range(0, 3);

        if (number == 1)
        {
            activatedWorld = SnowWorld;
        }
        else if (number == 2)
        {
            activatedWorld = GrassWorld;
        }
        else
        {
            activatedWorld = DesertWorld;
        }

        activatedWorld.SetActive(true);
    }

    public GameObject getActiveWorld(){
        return activatedWorld;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
