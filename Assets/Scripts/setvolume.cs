﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setvolume : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Signal")
        {
            GetComponent<AudioSource>().volume = 0.05f;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Signal")
        {
            GetComponent<AudioSource>().volume = 0;
        }
    }
}
