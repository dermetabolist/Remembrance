using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletnew : MonoBehaviour
{

    public float Speed = 3;
    Rigidbody2D rb;
    Vector2 targVec;
    GameObject player;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        targVec = player.transform.position - transform.position;
    }
    void Update()
    {
        rb.AddForce(targVec * Speed * Time.deltaTime);
    }
}
