using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float movespeed = 25f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb  = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(1f, 1f) * movespeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}