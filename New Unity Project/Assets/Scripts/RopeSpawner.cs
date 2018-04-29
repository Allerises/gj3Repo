using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeSpawner : MonoBehaviour
{

    public GameObject rope;

    private Transform ropeT;
    private Camera cam;
    Rigidbody rb;

    public float pull;

    // Use this for initialization
    void Start()
    {
        cam = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        ropeT = rope.transform;

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        Vector3 hitPoint = Vector3.zero;
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            Vector3 worldMouse = cam.ScreenToWorldPoint(mousePos);
            worldMouse = new Vector3(worldMouse.x, worldMouse.y, 0f);
            //Debug.Log(worldMouse);
            Vector3 dir = worldMouse - transform.position;


            if (Physics.Raycast(transform.position, dir, out hit))
            {
                if (hit.collider.tag == "Level")
                {
                    hitPoint = hit.point;

                    var r = GameObject.FindWithTag("rope");
                    if (r)
                    {
                        Destroy(r);
                    }

                    Vector3 pos = hit.point - Vector3.up * 1f;
                    Transform ropeN = Instantiate(ropeT, pos, Quaternion.identity);
                    ropeN.LookAt(transform.position);
                    Vector3 len = hit.point - transform.position;
                    ropeN.localScale.Set(ropeN.localScale.x, len.sqrMagnitude, ropeN.localScale.z);
                    ropeN.LookAt(transform.position);
                    rb.isKinematic = false;
                    GetComponent<SpringJoint>().connectedBody = ropeN.GetComponent<Rigidbody>();

                }
            }
        }
        if (Input.GetMouseButton(1))
        {
            rb.useGravity = false;
            transform.position = Vector3.MoveTowards(transform.position, hitPoint, pull * Time.deltaTime);
        }
        if (Input.GetMouseButtonUp(1))
        {
            rb.useGravity = true;
        }
    }
}
