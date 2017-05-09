using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = .05f;

	void Start ()
    {
        //transform.Rotate(0, 0, 0);
    }
	
	void Update ()
    {
        transform.Translate(Vector2.up * speed);
	}
}
