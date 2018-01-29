using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverCanvasSelfDisable : MonoBehaviour {
    public GameObject winnerText1;
    public GameObject winnerText2;
    bool first = true;

	// Use this for initialization
	void Start () {
        if (first)
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().gameEndCanvas = gameObject;
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().winnerText1 = winnerText1;
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().winnerText2 = winnerText2;
            gameObject.SetActive(false);
            Debug.Log("canvas start runs");
            first = false;
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
