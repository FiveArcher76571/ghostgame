using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneShifter : MonoBehaviour
{
    public void to_tutorial() {
        SceneManager.LoadScene("Tutorial and Story", LoadSceneMode.Single);
    }
    public void to_menu() {
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
    }
    public void to_gameover() {
        SceneManager.LoadScene("Game Over", LoadSceneMode.Single);
    }
    public void to_game() {
        SceneManager.LoadScene("BlankScene", LoadSceneMode.Single);
    }
    public void to_exit() {
        Application.Quit();
    }
    public void to_win() {
        SceneManager.LoadScene("Win!", LoadSceneMode.Single);
    }
}
