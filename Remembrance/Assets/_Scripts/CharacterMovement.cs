using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    float speed = 1.5f;
    float rotSpeed = 3f;
    float Timer = 0;

    public GameObject AimPoint;
    public GameObject Cannon;
    public GameObject Spawner;

    public Transform AimTarget;
    public Transform Bullet;

    float deltaX;
    float deltaY;


    void Start ()
    {

    }
	
	
	void Update ()
    {
        MoveCharacter();

        AimAndShoot();

        //when Dash Aquired
            //Dash();

        //when Shield acquired
            //Shield();

        //when Blast acquired
            //Blast();
	}

    //TODO: MoveCharacter();
    void MoveCharacter()
    {
        //wenn Input x größer als wert
            //dann bewege nach links
        if (Input.GetAxis("Horizontal") < -0.5)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetAxis("Horizontal") > 0.5)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        //wenn Input y größer als wert
            //dann bewege nach links
        if (Input.GetAxis("Vertical") < -0.5)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (Input.GetAxis("Vertical") > 0.5)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }

    //TODO: ShootCannon();
    void AimAndShoot()
    {
        //kanone zielt immer auf AimPoint
        //AimPoint.transform.LookAt(AimTarget);

        //Aimpont berechnet position aus Parent + Axis-Input
        AimPoint.transform.position = new Vector2(transform.position.x - Input.GetAxis("RightStick_Horizontal"), transform.position.y - Input.GetAxis("RightStick_Vertical"));

        //Wenn Input != 0, dann instantiere bullets
        if (Input.GetAxis("RightStick_Horizontal") > 0.8 || Input.GetAxis("RightStick_Horizontal") < -0.8 || Input.GetAxis("RightStick_Vertical") > 0.8 || Input.GetAxis("RightStick_Vertical") < -0.8)
        {
            Timer += Time.deltaTime;
            if (Timer > 1)
            {
                Quaternion BulletRot = Quaternion.Euler(AimPoint.transform.rotation.x, AimPoint.transform.rotation.y, AimPoint.transform.rotation.z);
                Instantiate(Bullet, new Vector2(AimPoint.transform.position.x, AimPoint.transform.position.y), BulletRot);
                Timer = 0;
            }
        }

        //ShootCannon()
        //LookAt zielpunkt
        //instantiere bullets mit richtung und rotation des spawners
    }

    //TODO: Dash();
    void Dash()
    {

    }

    //TODO: Shield();
    void Shield()
    {

    }

    //TODO: Blast();
    void Blast()
    {
        //TODO: ShieldCooldown();
    }

}
