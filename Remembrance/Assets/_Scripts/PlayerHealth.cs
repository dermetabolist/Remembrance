using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public Image HealthBar;

	void Start ()
    {
        GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float healthAmount;
        healthAmount = (StaticHolder.PlayerHealth / 100);
        HealthBar.fillAmount = healthAmount;
	}
}
