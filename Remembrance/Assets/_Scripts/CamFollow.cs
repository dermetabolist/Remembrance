using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour 
{
    public GameObject objectToFollow;

    public float speed = 2.0f;

    void Update()
    {
       

        float interpolation = speed * Time.deltaTime;

        Vector2 position;

        position.x = this.transform.position.x;
        position.y = this.transform.position.y;

        position.x = Mathf.Lerp(this.transform.position.x, objectToFollow.transform.position.y, interpolation);
        position.y = Mathf.Lerp(this.transform.position.y, objectToFollow.transform.position.x, interpolation);

        this.transform.position = position;
    }
}


