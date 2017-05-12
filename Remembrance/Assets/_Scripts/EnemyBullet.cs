using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {

    float Speed = 5f;
    float Timer = 0f;
   
    
    private void Start()
    {
     
    }

    void Update()
    {
        //Bewegung der Bullet
        transform.Translate(Vector2.up * Speed * Time.deltaTime);
        Timer += Time.deltaTime;

        if (Timer > 4)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }


}
