using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClashSound : MonoBehaviour {
    public AudioClip[] clashSounds;
    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag== "Weapon" && gameObject.tag =="CGAudio2")|| (collision.gameObject.tag == "Weapon2" && gameObject.tag == "CGAudio1"))
        {
            audioSource.clip = clashSounds[Random.Range(0, clashSounds.Length - 1)];
            audioSource.Play();
            Debug.Log("clash sound played"+collision.gameObject.tag+gameObject.tag);
        }
    }
}
