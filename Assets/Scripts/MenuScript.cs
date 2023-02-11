using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {
    public void StartGame() {
        SceneManager.LoadScene("Main");
    }

    public void GoToSettings() {
        SceneManager.LoadScene("Settings");
    }
}

