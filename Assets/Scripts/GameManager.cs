using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject touche;
    public GameObject player1ScoreDisplay;
    public GameObject player2ScoreDisplay;
    public int player1Score;
    public int player2Score;
    public int firstToXWins;
    public GameObject gameEndCanvas;
    public GameObject winnerText1;
    public GameObject winnerText2;
    public GameObject audioHandler;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.sceneLoaded += LevelLoaded;
    }

    private void LevelLoaded(Scene arg0, LoadSceneMode arg1)
    {
        print("Loading");
        player1ScoreDisplay = GameObject.Find("Player1 Score");
        player2ScoreDisplay = GameObject.Find("Player2 Score");
        audioHandler = FindObjectOfType<AudioHandler>().gameObject;
        UpdateScores();
    }

    // Update is called once per frame
    void Update () {

	}
    public void SetUpToucheText(GameObject touchein) {
        touche = touchein;
    }

    public void Player1Scores() {
        touche.SetActive(true);
        player1Score++;
        float secondsToWait = 1.5f;
        if (player1Score==firstToXWins|| player2Score==firstToXWins)
        {
            touche.SetActive(false);
            gameEndCanvas.SetActive(true);
            if (player1Score>player2Score)
            {
                winnerText1.SetActive(true);
                secondsToWait = audioHandler.GetComponent<AudioHandler>().PlayQuip(1);
            }
            else
            {
                winnerText2.SetActive(true);
                secondsToWait = audioHandler.GetComponent<AudioHandler>().PlayQuip(2);
            }
            player1Score = 0;
            player2Score = 0;
        }

        StartCoroutine(WaitAndReloadScene(secondsToWait));
    }

    public void Player2Scores()
    {
        touche.SetActive(true);
        player2Score++;
        float secondsToWait=1.5f;
        if (player1Score == firstToXWins || player2Score == firstToXWins)
        {
            touche.SetActive(false);
            gameEndCanvas.SetActive(true);
            if (player1Score > player2Score)
            {
                winnerText1.SetActive(true);
                secondsToWait = audioHandler.GetComponent<AudioHandler>().PlayQuip(1);
                
            }
            else
            {
                winnerText2.SetActive(true);
                secondsToWait = audioHandler.GetComponent<AudioHandler>().PlayQuip(2);
            }
            player1Score = 0;
            player2Score = 0;
        }
        StartCoroutine(WaitAndReloadScene(secondsToWait));
    }

    private void UpdateScores() {
        player1ScoreDisplay.GetComponent<Text>().text = player1Score.ToString();
        player2ScoreDisplay.GetComponent<Text>().text = player2Score.ToString();
    }

    IEnumerator WaitAndReloadScene(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }


}
