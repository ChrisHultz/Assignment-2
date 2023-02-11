using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System; // for date and time

public class PauseGame : MonoBehaviour {
    public Text timeText;
    public Button resumeButton;
    private bool isPaused = false;

    void Start() {
        timeText.text = "Time: " + DateTime.Now.ToString();
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(isPaused) {
                ResumeGame();
            }
            else {
                PauseTheGame();
            }
        }
        if (!isPaused) {
            timeText.text = "Time: " + DateTime.Now.ToString();
        }
    }
    void PauseTheGame() {
        Time.timeScale = 0;
        isPaused = true;
        timeText.text = "Game is paused";
        resumeButton.gameObject.SetActive(true);
    }
    public void ResumeGame() {
        Time.timeScale = 1;
        isPaused = false;
        timeText.text = "Time: " + DateTime.Now.ToString();
        resumeButton.gameObject.SetActive(false);
    }
}