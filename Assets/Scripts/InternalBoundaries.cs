using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InternalBoundaries : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Signal")
        {
            collision.gameObject.GetComponent<BrainSignalController>().EnterTrigger(transform.parent.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Signal")
        {
            collision.gameObject.GetComponent<BrainSignalController>().ExitTrigger();
        }
    }
}
