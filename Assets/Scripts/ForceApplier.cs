using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceApplier : MonoBehaviour {
    AudioHandler audioHandler;

	// Use this for initialization
	void Start () {
        audioHandler = GameObject.FindGameObjectWithTag("AudioHandler").GetComponent<AudioHandler>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ApplyForce(Vector3 atPosition,Vector3 forceToApply) {
        if (gameObject.name == "head_basic")
        {
            GetComponent<Rigidbody2D>().AddForceAtPosition(forceToApply * 50, atPosition, ForceMode2D.Impulse);
        }
        else
        {
            GetComponent<Rigidbody2D>().AddForceAtPosition(forceToApply * 150, atPosition, ForceMode2D.Impulse);
        }
        audioHandler.PlayRandomGrunt();
    }
}
