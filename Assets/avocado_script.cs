using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avocado_script : MonoBehaviour
{
    public float jumpForce = 5f;
    public float jumpHeight = 1f; // height of the jump in units
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            //rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            rb.velocity = new Vector3(0, 5, 0);
        }

        // Add a sine wave motion to the object's y position
        //transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.time) * jumpHeight, transform.position.z);
        if (Input.GetKey("up"))
        {
            rb.velocity = new Vector3(0, 0, 5);
        }

        if (Input.GetKey("down"))
        {
            rb.velocity = new Vector3(5, 0, 0);
        }
    }
}