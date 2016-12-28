using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpSpeed;
    public float jumpLimit;

    public Rigidbody projectile;
    public float shootSpeed = 20;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //transform.Translate(Vector3.up * 100 * Time.deltaTime, Space.World);
            //rb.AddForce(new Vector3(0.0f, jumpSpeed, 0.0f), ForceMode.Impulse);
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);

        rb.AddForce(movement * moveSpeed);
    }
}