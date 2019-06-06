using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButtons : MonoBehaviour
{

    public void Replay()
    {
        SceneManager.LoadScene("ScoreTest");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
