using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    float speed = 2f;
	
	void Start ()
    {
		
	}
	
	
	void Update ()
    {
        MoveCharacter();

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
        if(Input.GetButton("Horizontal") && Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetButton("Horizontal") && Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        if (Input.GetButton("Vertical") && Input.GetAxisRaw("Vertical") > 0)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (Input.GetButton("Vertical") && Input.GetAxisRaw("Vertical") < 0)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
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
