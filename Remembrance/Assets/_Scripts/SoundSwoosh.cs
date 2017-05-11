using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSwoosh : MonoBehaviour {

    public AudioClip Swoosh;
    public AudioSource audio;
    float RandomPitch;

	void Start ()
    {
        audio = GetComponent<AudioSource>();
        RandomPitch = 1f;
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Bullet")
        {

            print("sehe bullet");
            RandomPitch = Random.Range(1f, 2.5f);
            audio.pitch = RandomPitch;
            audio.PlayOneShot(Swoosh, 0.75F);
        }
    }
}
