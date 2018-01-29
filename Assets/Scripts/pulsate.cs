using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulsate : MonoBehaviour {

    Vector3 maxScale = new Vector3(0.6f, 0.6f, 0.6f);
    Vector3 minScale = new Vector3(0.5f, 0.5f, 0.5f);
    public float speed = 0.1f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.localScale = transform.localScale + transform.localScale * Time.deltaTime * speed;
        if (transform.localScale.x >= maxScale.x)
        {
            speed = -speed;
        }
        if (transform.localScale.x <= minScale.x) {
            speed = -speed;
        }
	}
}
