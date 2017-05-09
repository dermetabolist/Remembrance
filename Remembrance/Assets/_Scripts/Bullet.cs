using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = .05f;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        transform.Translate(Vector2.up * speed);
	}
}
