using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarvinShootScript : MonoBehaviour
{
    float speed = 50f;
    float timing = 0f;
    float timingWait = 0.25f;

    public Transform BulletSpawner;
    public GameObject Bullet;
    public GameObject Cannon;
    public GameObject Player;



    void Start()
    {
        Bullet = Resources.Load<GameObject>("Bullet");
    }

    void Update()
    {
        moveCanonPS4();

        //if(Input.GetButton("Fire1"))
        //{
        //    doShooting();
        //}

        if (Input.GetAxisRaw("PS4_RightStickX") < -0.74 || Input.GetAxisRaw("PS4_RightStickX") > 0.74)
        {   
            doShooting();
        }

        if (Input.GetAxisRaw("PS4_RightStickY") < -0.74 || Input.GetAxisRaw("PS4_RightStickY") > 0.74)
        {
            doShooting();
        }
    }

    private void moveCanonPS4()
    {
        // We are going to read the input every frame
        //Vector3 vNewInput = new Vector3(Input.GetAxis("PS4_RightStickY"), Input.GetAxis("PS4_RightStickX"), 0.0f);

        // Apply the transform to the object  
        float angle = Mathf.Atan2(Input.GetAxis("RightStick_Vertical"), Input.GetAxis("RightStick_Horizontal")) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle); 
    }

    private void doShooting()
    {
        timing += Time.deltaTime;
        if (timing >= timingWait)
        {
            timing = 0;
            GameObject goBullet = (GameObject)Instantiate(Bullet, BulletSpawner.position, BulletSpawner.transform.rotation);
        goBullet.name = "Bullet";
        }
    }
}