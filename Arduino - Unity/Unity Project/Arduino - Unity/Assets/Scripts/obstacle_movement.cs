using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_movement : MonoBehaviour
{

    public float speed;

    float destroy_countdown = 5;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        float speedAfter = Random.Range(speed, speed - 10);
        rb.velocityX = speedAfter;
    }

    private void Update()
    {
        destroy_countdown -= Time.deltaTime;

        if ( destroy_countdown <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
