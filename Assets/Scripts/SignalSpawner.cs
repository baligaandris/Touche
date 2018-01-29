using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalSpawner : MonoBehaviour {

    public GameObject signalPrefab;
    public GameObject activeSignal;
    public GameObject headTrigger;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (activeSignal == null)
        {
            activeSignal = Instantiate(signalPrefab,transform.position,Quaternion.identity);
            activeSignal.transform.rotation = Quaternion.Euler(activeSignal.transform.rotation.x, activeSignal.transform.rotation.y, 180);
            activeSignal.GetComponent<BrainSignalController>().setHeadTrigger(headTrigger);
        }
	}
}
