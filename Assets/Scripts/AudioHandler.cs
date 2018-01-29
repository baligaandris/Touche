using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioHandler : MonoBehaviour {

    public AudioClip[] grunts;
    public AudioClip[] P1WinQuips;
    public AudioClip[] P1LoseQuips;
    public AudioClip[] P2WinQuips;
    public AudioClip[] P2LoseQuips;


    bool first = false;

    private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        UnityEngine.Random.seed = (int)System.DateTime.Now.Ticks;
    }
	// Update is called once per frame
	void Update () {
        if (first)
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().audioHandler = gameObject;
            first = false;
        }
	}
    public void PlayRandomGrunt() {
        int gruntIndex = UnityEngine.Random.Range(0, grunts.Length);
        audioSource.clip = grunts[gruntIndex];
        audioSource.Play();
    }




    public float PlayQuip(int winner) {
        print("playquip called" +winner);
        int speaker = UnityEngine.Random.Range(1, 3);
        if (speaker==1)
        {
            if (winner == 1)
            {
                audioSource.clip = P1WinQuips[UnityEngine.Random.Range(0, P1WinQuips.Length)];
                print("Player1 wins speaks");
            }
            else
            {
                audioSource.clip = P1LoseQuips[UnityEngine.Random.Range(0, P1LoseQuips.Length)];
            }
        }
        else
        {
            if (winner==2)
            {
                audioSource.clip = P2WinQuips[UnityEngine.Random.Range(0, P2WinQuips.Length)];
            }
            else
            {
                audioSource.clip = P2LoseQuips[UnityEngine.Random.Range(0, P2LoseQuips.Length)];
                print("Player1 wins, p2 speaks");
            }
        }
        audioSource.Play();
        return (audioSource.clip.length);
    }
}
