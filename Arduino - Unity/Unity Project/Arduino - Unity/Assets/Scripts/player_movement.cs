using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine;

public class player_movement : MonoBehaviour
{

    public float jump_velocity = 10;

    SerialPort data_stream = new SerialPort("COM6", 19200);

    Rigidbody2D rb;


    string value;

    bool jump = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        data_stream.Open();
    }

    // Update is called once per frame
    void Update()
    {
        value = data_stream.ReadLine();

        if (jump == true && int.Parse(value) > 0 || Input.GetButtonDown("Jump") && jump == true)
        {
            rb.velocityY = jump_velocity;
        }

        print(value);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Jump_Reset"))
        {
            jump = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Jump_Reset"))
        {
            jump = false;
        }
    }
}
