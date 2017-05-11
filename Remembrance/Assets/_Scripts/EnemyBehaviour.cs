using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {

    //legt die gesundheit fest
    float health = 5f;

    //legt den punktwert für den score fest
    int scoreValue = 100;

    //legt rotationsgeschwindigkeit der sphere fest
    float rotSpeed = 25;
    //legt geschwindigkeit von pillar fest
    float moveSpeed = 5;
    //legt die Schussfrequenz fest
    float ShotDelay = 1;

    float Timer = 0f;

    GameObject Player;
    public Transform Spawner1;
    public Transform Spawner2;
    public Transform Spawner3;
    public Transform Spawner4;
    public Transform EnemyBullet;

    public AudioSource audio;
    public AudioClip Laser;

	public void Start ()
    {
        Player = GameObject.FindWithTag("Player");
	}
    

    //TODO: EnemyMovement();
    public void SphereMovement()
    {
        //transform.Rotate(Player.transform.position * rotSpeed);
        transform.RotateAround(Player.transform.position, Vector3.forward, rotSpeed * Time.deltaTime);
    }

   

    //TODO: EnemyShooting();
    public void EnemyShooting()
    {
        Timer += Time.deltaTime;
        if(Timer > ShotDelay)
        {
            audio.PlayOneShot(Laser, 1f);
            Instantiate(EnemyBullet, Spawner1.transform.position, Spawner1.transform.rotation);
            Instantiate(EnemyBullet, Spawner2.transform.position, Spawner2.transform.rotation);
            Instantiate(EnemyBullet, Spawner3.transform.position, Spawner3.transform.rotation);
            Instantiate(EnemyBullet, Spawner4.transform.position, Spawner4.transform.rotation);
            Timer = 0f;
        }
    }

    //TODO: EnemyHealth();
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "PlayerBullet")
        {
            health--;
        }
        if(health <1)
        {
            StaticHolder.ScoreCounter += scoreValue;
            Destroy(gameObject);
        }
    }
}
