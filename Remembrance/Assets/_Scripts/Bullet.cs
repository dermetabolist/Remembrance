using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float Speed = 5f;
    float Timer = 0f;
 
    void Update()
    {
        transform.Translate(Vector2.up * Speed * Time.deltaTime);
        Timer += Time.deltaTime;
        if(Timer > 4)
        {
            Destroy(gameObject);
        }
    }
}
