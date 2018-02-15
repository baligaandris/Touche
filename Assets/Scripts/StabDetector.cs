using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StabDetector : MonoBehaviour {

    GameManager gameManager;
    stabaudio audioHandler;

	// Use this for initialization
	void Start () {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        audioHandler = GameObject.FindGameObjectWithTag("StabAudio").GetComponent<stabaudio>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Weapon")
        {
            gameManager.Player1Scores();
            collision.gameObject.GetComponent<PolygonCollider2D>().enabled = false;
            GameObject.FindGameObjectWithTag("Weapon2").GetComponent<PolygonCollider2D>().enabled = false;
            audioHandler.PlayStabSound();
            GameObject.FindGameObjectWithTag("Head2").GetComponent<Animator>().SetTrigger("WasHit 0");
            GameObject.FindGameObjectWithTag("Head1").GetComponent<Animator>().SetTrigger("DidHit 0");
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("Brain").Length; i++)
            {
                Destroy(GameObject.FindGameObjectsWithTag("Brain")[i]);
            }
            for (int j = 0; j < GameObject.FindGameObjectsWithTag("Signal").Length; j++)
            {
                Destroy(GameObject.FindGameObjectsWithTag("Signal")[j]);
            }
            
        }
        if (collision.gameObject.tag == "Weapon2")
        {
            gameManager.Player2Scores();
            collision.gameObject.GetComponent<PolygonCollider2D>().enabled = false;
            GameObject.FindGameObjectWithTag("Weapon").GetComponent<PolygonCollider2D>().enabled = false;
            audioHandler.PlayStabSound();
            GameObject.FindGameObjectWithTag("Head1").GetComponent<Animator>().SetTrigger("WasHit 0");
            GameObject.FindGameObjectWithTag("Head2").GetComponent<Animator>().SetTrigger("DidHit 0");
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("Brain").Length; i++)
            {
                Destroy(GameObject.FindGameObjectsWithTag("Brain")[i]);
            }
            for (int j = 0; j < GameObject.FindGameObjectsWithTag("Signal").Length; j++)
            {
                Destroy(GameObject.FindGameObjectsWithTag("Signal")[j]);
            }
        }
        
    }
}
