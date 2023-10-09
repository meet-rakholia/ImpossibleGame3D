using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    public float forwardSpeed = 0.05f;
    public float jumpForce = 200f;
    public float pullDownForce = -10f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
            rigidbody.AddForce(0, jumpForce, 0); 
        }
        transform.Translate(0,0,forwardSpeed);
        
    }

    private void FixedUpdate()
    {
        Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
        if (rigidbody.velocity.y < -.1f)
        {
            rigidbody.AddForce(0,pullDownForce,0);
        }
    }
}
