using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerCreator : MonoBehaviour {
    public GameObject gameManagerPrefab;
    public GameObject MusicObjectPrefab;
    private GameObject gameManager;
	// Use this for initialization
	void Awake () {
        if (GameObject.FindGameObjectWithTag("GameManager")==null)
        {
            Instantiate(gameManagerPrefab);
        }
        if (GameObject.FindGameObjectWithTag("MusicObject")==null)
        {
            Instantiate(MusicObjectPrefab);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
