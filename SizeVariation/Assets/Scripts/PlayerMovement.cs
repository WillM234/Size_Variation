using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    private float thrust = 100f;
    private float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))//move right
            {
            rb.AddForce(transform.right * speed);
        }
        if(Input.GetKey(KeyCode.A))// move left
            {
            rb.AddForce(-transform.right * speed);
            }
        if(Input.GetKeyDown(KeyCode.Space))//jump control
        {
            rb.AddForce(transform.up * thrust);
        }
    }
}
