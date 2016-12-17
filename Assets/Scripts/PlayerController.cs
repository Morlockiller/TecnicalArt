using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown( KeyCode.Space ))
        {
            //transform.Translate(Vector3.up * 100 * Time.deltaTime, Space.World);
            rb.AddForce(new Vector3(0.0f, 5, 0.0f), ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);

        rb.AddForce(movement * speed);
    }
}