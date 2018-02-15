using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stabaudio : MonoBehaviour {
    public AudioClip[] stabs;
    AudioSource audioSource;
    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void PlayStabSound()
    {
        audioSource.clip = stabs[Random.Range(0, stabs.Length - 1)];
        audioSource.Play();
    }
}
