//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class bulletSpawner : MonoBehaviour {
//    GameObject Player;
//    GameObject Gun;
//    GameObject Cookie;

//     // Schussbereitschaft
//    public float TimingWait = 2f;

//    // Timing = vrg. Zeit seit letzter Kugel 
//    public float Timing = 0f;
//    //    public Transform CookieSpawner;

//    public float CookieSpeed = 3;
//    public enum  PlayerDistance
//    {
//        LOW = 6,
//        MEDIUM = 8,
//        LARGE = 10
//    }
    
//    public enum FacingDirections // Blickrichtung Gun
//    {
//        UP = 270,
//        DOWN = 90,
//        LEFT = 180,
//        RIGHT = 0
//    }
//    public enum Difficulty
//    {
//        VERY_EASY = 2,
//        EASY = 4,
//        MEDIUM = 6,
//        HARD = 8,
//        VERY_HARD = 100
//    }
//    public FacingDirections GunsDirection = FacingDirections.LEFT;
//    public Difficulty GunsDifficulty = Difficulty.VERY_EASY;
//    // PlayerDistance bestimmt Geschossreichweite
//    public PlayerDistance PlayersDistance = PlayerDistance.LARGE;
//    // Use this for initialization
//    void Start ()
//    {

//        Player = GameObject.FindGameObjectWithTag("Player");
//        Gun = this.transform.GetChild(0).gameObject;
//        Cookie = Resources.Load<GameObject>("Cookie");
//    }
	
//	// Update is called once per frame
//	void Update ()
//    {

//        PositionGun((float)GunsDifficulty / 10);
//        ShotGun();
//	}

//    float dragAngle = 0;

//    void PositionGun(float theSpeed)
//    {
        
//        Vector3 _vec2targ = Player.transform.position - Gun.transform.position; // bezieht sich auf das erste child
//        float _angle = Mathf.Atan2(_vec2targ.y, _vec2targ.x) * Mathf.Rad2Deg; // Umwandlung Winkelradiant in Grad (Winkel)
//        _angle -= (float)GunsDirection ;
//        dragAngle = _angle;
//        Quaternion q = Quaternion.AngleAxis(_angle, Vector3.forward);
//        Gun.transform.rotation = Quaternion.Slerp(Gun.transform.rotation, q, Time.deltaTime * theSpeed);// Rotieren lassen
        
//    }

//    void ShotGun()
//    {
//        // Distance zum Spieler (eigene pos.,spieler pos.)
//        float distanceToPlayer = Vector3.Distance(transform.position, Player.transform.position);
//        if ((float)PlayersDistance < distanceToPlayer) // Stop wenn PlayerDistance (benutzerdef.) größer
//        {
//            return;
//        }

//        // Timing = vrg. Zeit seit letzter Kugel neu berechnen
//        Timing += Time.deltaTime;
//        if (Timing < TimingWait) // Wenn Timing seit letzter Kugel kleiner Schussbereitschaft
//        {
//            return;
//        }

//        // Dann Timing Null für neue Kugelberechn.
//        Timing = 0;

//        // Kugel muss in Schussrichtung aus der Gun kommen
//        // Dazu muss Pos. für Kugel an der Gun bestimmt werden
//        // Über die fkt. Gun.transform.rotation.ToAngleAxis wird akt. Winkel der Gun best.
//        float dragDist = -2;
//        float  _angle = 0.0f;
//        Vector3 axis = Vector3.zero;
//        Gun.transform.rotation.ToAngleAxis(out _angle, out axis);

//        if (axis.z < 0)
//        {
//            _angle = 360 - _angle;
//        }
//        // Anhand vom erhaltenen Winkel -> neue pos. berechn. für Kugel
//        axis.x = 1 * Mathf.Cos(_angle * Mathf.PI / 180) * dragDist;
//        axis.y = 1 * Mathf.Sin(_angle * Mathf.PI / 180) * dragDist;


//        // Instanzierung d. Cookie mit neu berechn. Pos.
//        GameObject _spawnCookie = (GameObject)Instantiate(Cookie, Gun.transform.position + axis, Gun.transform.rotation);

//        Bullet cookie = _spawnCookie.GetComponent<bulletnew>();
//        cookie.Speed = CookieSpeed;

//        _spawnCookie.name = "SpawnedCookie";

         

//    }

//    //void OnTriggerEnter2D(Collider2D col )
//    //{
//    //   bool  characterInQuicksand = true;
//    //}
//    private void OnTriggerEnter2D(Collider2D collision)
//    {

//    }
//}
