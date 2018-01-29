using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToucheSelfDisable : MonoBehaviour {
    float countdown;
	// Use this for initialization
	void Start () {
        GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().SetUpToucheText(gameObject);
        gameObject.SetActive(false);
	}
    private void OnEnable()
    {
        countdown = 2f;
    }


    // Update is called once per frame
    void Update () {
        countdown -= Time.deltaTime;
        if (countdown<=0)
        {
            gameObject.SetActive(false);
        }
	}
}
