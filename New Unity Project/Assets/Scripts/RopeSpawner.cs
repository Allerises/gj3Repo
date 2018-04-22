using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeSpawner : MonoBehaviour
{

    public GameObject rope;

    private Transform ropeT;
    private Camera cam;

    // Use this for initialization
    void Start()
    {
        cam = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        ropeT = rope.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            Vector3 worldMouse = cam.ScreenToWorldPoint(mousePos);
            worldMouse = new Vector3(worldMouse.x, worldMouse.y, 0f);
            //Debug.Log(worldMouse);
            Vector3 dir = worldMouse - transform.position;

            RaycastHit hit;
            if (Physics.Raycast(transform.position, dir, out hit))
            {
                if (hit.collider.tag == "Level")
                {
                    Vector3 pos = (hit.point + transform.position) / 2;
                    Transform rope = Instantiate(ropeT, pos, Quaternion.identity);
                    
                }
            }
        }
    }
}
