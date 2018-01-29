using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowFist : MonoBehaviour {

    public GameObject fist;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = fist.transform.position;
	}
}
