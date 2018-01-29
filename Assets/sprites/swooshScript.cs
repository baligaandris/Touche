using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swooshScript : MonoBehaviour {

    public AudioClip[] swooshes;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<Rigidbody2D>().velocity.magnitude >20 && !GetComponent<AudioSource>().isPlaying)
        {
            GetComponent<AudioSource>().clip = swooshes[Random.Range(0, swooshes.Length - 1)];
            GetComponent<AudioSource>().Play();
            Debug.Log("SWOOOSH");
        }

	}
}
