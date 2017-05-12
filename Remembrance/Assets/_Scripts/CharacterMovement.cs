using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    float speed = 1.5f;
    float dashspeed = 0f;
    float rotSpeed = 3f;
    float Timer = 0;

    bool DoDash = false;

    public GameObject AimPoint;
    public GameObject Cannon;
    public GameObject Spawner;

    public Transform AimTarget;
    public Transform Bullet;

    public Rigidbody2D rb;

    float deltaX;
    float deltaY;

    Animator anim;


    void Start ()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
	
	
	void Update ()
    {
        MoveCharacter();
        
        AimAndShoot();

        //when Dash Aquired
        Dash();

        //when Shield acquired
        //Shield();

        //when Blast acquired
        //Blast();

        

    }

    //TODO: MoveCharacter();
    void MoveCharacter()
    {
        if (Input.GetAxis("Horizontal") > -0.5 || Input.GetAxis("Horizontal") < 0.5 || Input.GetAxis("Vertical") > -0.5 || Input.GetAxis("Vertical") < 0.5)
        {
            anim.SetBool("IsWalking", false);
        }


            //wenn Input x größer als wert
            //dann bewege nach links
            if (Input.GetAxis("Horizontal") < -0.5)
        {
            anim.SetBool("FacingRight", false);
            anim.SetBool("IsWalking", true);
            transform.Translate(Vector2.left * (speed + dashspeed) * Time.deltaTime);
            
        }
        if (Input.GetAxis("Horizontal") > 0.5)
        {
            anim.SetBool("FacingRight", true);
            anim.SetBool("IsWalking", true);
            transform.Translate(Vector2.right * (speed + dashspeed) * Time.deltaTime);
            
        }

        //wenn Input y größer als wert
            //dann bewege nach links
        if (Input.GetAxis("Vertical") < -0.5)
        {
            anim.SetBool("IsWalking", true);
            transform.Translate(Vector2.up * (speed + dashspeed) * Time.deltaTime);
            
        }
        if (Input.GetAxis("Vertical") > 0.5)
        {
            anim.SetBool("IsWalking", true);
            transform.Translate(Vector2.down * (speed + dashspeed) * Time.deltaTime);
        }
    }

    //TODO: ShootCannon();
    void AimAndShoot()
    {
        //kanone zielt immer auf AimPoint
        Cannon.transform.LookAt(AimTarget);

        //Aimpont berechnet position aus Parent + Axis-Input
        
        AimPoint.transform.position = new Vector2(transform.position.x - (Input.GetAxis("RightStick_Horizontal") / 10),transform.position.y - (Input.GetAxis("RightStick_Vertical")/10));

        //Wenn Input != 0, dann instantiere bullets
        if (Input.GetAxis("RightStick_Horizontal") > 0.8 || Input.GetAxis("RightStick_Horizontal") < -0.8 || Input.GetAxis("RightStick_Vertical") > 0.8 || Input.GetAxis("RightStick_Vertical") < -0.8)
        {
            Timer += Time.deltaTime;
            if (Timer > 0.25f)
            {
                //Vector3 targetDir = AimPoint.transform.position - transform.position;
                //float angle = Vector3.Angle(targetDir, transform.forward);

                //float xRot = AimPoint.transform.position.x - transform.position.x;
                //float yRot = AimPoint.transform.position.y - transform.position.y;
                //float zRot = AimPoint.transform.position.z - transform.position.z;

                //transform.eulerAngles = new Vector3(xRot, yRot, zRot);

                Instantiate(Bullet, new Vector3(AimPoint.transform.position.x, AimPoint.transform.position.y), Quaternion.identity);
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
        //if(Input.GetButtonDown("PS4_L2"))
        //{
            
        //}
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
