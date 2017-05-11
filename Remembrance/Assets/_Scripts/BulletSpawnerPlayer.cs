//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class BulletSpawnerPLayer : MonoBehaviour {
//    GameObject Player;
//    GameObject Enemies;
//    GameObject Cookie;
//    GameObject Bot;

//    // Timing = vrg. Zeit seit letzter Kugel 
//    //    public Transform CookieSpawner;
//    // Schussbereitschaft
//    public float TimingWait = 0f;
//    public float Timing = 0f;
    

//    public float CookieSpeed = 3f;
//    public enum TargetDistance
//    {
//        LOW = 6,
//        MEDIUM = 8,
//        LARGE = 10
//    }
    
//    public TargetDistance TargetsDistance = TargetDistance.LARGE;

//    void Start ()
//    {
//        Player = GameObject.FindGameObjectWithTag("Player");
//        //Enemies =GameObject
//        //Cookie = Resources.Load<GameObject>("Cookie");
//    }
	
//	void Update ()
//    {
//        ShotGun();
//	}
//    float dragAngle = 0;

//    void ShotGun()
//    {
//        float TargetsDistance = Vector3.Distance(transform.position, Enemies.transform.position);
//        if ((float)Targete < TargetDistance)
//        {
//            return;
//        }
//        Timing += Time.deltaTime;
//        if (Timing < TimingWait)
//        {
//            return;
//        }
//        Timing = 0;
//        float dragDist = -2;
//        float _angle = 0.0f;
//        Vector3 axis = Vector3.zero;
//        if (axis.z < 0)
//        {
//            _angle
//        }
//    }
//}
