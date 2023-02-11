using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour {

    //Menu Button
    public void BackToMenu() {
        SceneManager.LoadScene("Menu");
    }
    
    public GameObject Player;
    public Dropdown ballSize;
    public Dropdown BallColor;
    public Text ColorName;
    private float size;
    public static float UpdateSize;
    public static Color passColor;

    public void changeBallSize() {
        switch(ballSize.value) {
            default:
                size = 1.0f;
                UpdateSize = size;
                break;
            case 1:
                size = 1.0f;
                UpdateSize = size;
                break;
            case 2:
                size = 2.0f;
                UpdateSize = size;
                break;
            case 3:
                size = 3.0f;
                UpdateSize = size;
                break;
        }

        Player.transform.localScale = new Vector3(UpdateSize,UpdateSize,UpdateSize);
        Player.transform.localPosition = new Vector3(Player.transform.localPosition.x, 0.5f * UpdateSize, Player.transform.localPosition.z);
    }

    public void ChooseColor() {
        switch (BallColor.value) {
            case 1:
                ColorName.text = BallColor.options[1].text;
                Player.GetComponent<Renderer>().material.color = Color.red;
                passColor = Player.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                ColorName.text = BallColor.options[2].text;
                Player.GetComponent<Renderer>().material.color = Color.white;
                passColor = Player.GetComponent<Renderer>().material.color = Color.white;
                break;
            case 3:
                ColorName.text = BallColor.options[3].text;
                Player.GetComponent<Renderer>().material.color = Color.blue;
                passColor = Player.GetComponent<Renderer>().material.color = Color.blue;
                break;
            default:
                ColorName.text = BallColor.options[0].text;
                Player.GetComponent<Renderer>().material.color = Color.black;
                passColor = Player.GetComponent<Renderer>().material.color = Color.black;
                break;
        }
    }
}
