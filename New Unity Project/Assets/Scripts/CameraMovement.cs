using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed;

    // Use this for initialization
    void Start()
    {
        rb = GameObject.FindWithTag("MainCamera").GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.right * speed;
    }
}
