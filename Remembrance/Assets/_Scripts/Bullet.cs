using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float Speed = 5f;
    float Timer = 0f;
    float angle;

    GameObject target;
    GameObject AimPoint;
    GameObject Player;
    Vector3 mouse_pos;
    Vector3 object_pos;

    private void Start()
    {
        AimPoint = GameObject.Find("AimPoint");
        Player = GameObject.Find("Player");
        target = this.gameObject;

        //rotiert Bullet in die Richtung des AimPoints
        mouse_pos = Player.transform.position - AimPoint.transform.position;
        mouse_pos.z = transform.position.z - AimPoint.transform.position.z; //The distance between the camera and object
        object_pos = target.transform.position;
        angle = Mathf.Atan2(mouse_pos.x, -mouse_pos.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));


    }

    void Update()
    {
        //Bewegung der Bullet
        transform.Translate(Vector2.up * Speed * Time.deltaTime);
        Timer += Time.deltaTime;

        if(Timer > 4)
        {
            Destroy(gameObject);
        }
    }
}
