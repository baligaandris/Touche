using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreYourself : MonoBehaviour {
    bool firstframe = true;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (firstframe)
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().player2ScoreDisplay = gameObject;
            firstframe = false;
        }
    }
}
