using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterDungeon01 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && StaticHolder.FinishedDungeons == 0)
        {
            SceneManager.LoadScene("_Scenes/Dungeon01");
        }

        if (other.tag == "Player" && StaticHolder.FinishedDungeons == 1)
        {
            SceneManager.LoadScene("_Scenes/Dungeon02");
        }

        if (other.tag == "Player" && StaticHolder.FinishedDungeons == 2)
        {
            SceneManager.LoadScene("_Scenes/Dungeon03");
        }

        if (other.tag == "Player" && StaticHolder.FinishedDungeons == 3)
        {
            SceneManager.LoadScene("_Scenes/Dungeon04");
        }

        if (other.tag == "Player" && StaticHolder.FinishedDungeons == 4)
        {
            SceneManager.LoadScene("_Scenes/Hell");
        }

    }
}
