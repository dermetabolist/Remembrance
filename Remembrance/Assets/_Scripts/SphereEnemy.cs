using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereEnemy : EnemyBehaviour {

	// Update is called once per frame
	void Update ()
    {
        EnemyShooting();
        SphereMovement();
	}

}
