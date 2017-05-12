using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceActivation : MonoBehaviour {

    public bool InArea = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            InArea = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            InArea = false;
        }
    }
}
