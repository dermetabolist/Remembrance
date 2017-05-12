using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarvinsBulletScript : MonoBehaviour
{
    float speed = 7;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.velocity = transform.up * speed;
        killFarBullets();
    }

     void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        Destroy(gameObject);
    }

    void killFarBullets()
    {
        if(transform.position.y > 5.28f || transform.position.y < -5.33f || transform.position.x < -9.32f || transform.position.x > 16f)
        {
            Destroy(gameObject);
        }
    }
}
