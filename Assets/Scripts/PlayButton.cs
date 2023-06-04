using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public GameObject canvas;

    public void OnClick()
    {
        GameState.isRunning = true;
        canvas.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Scene0");
    }
}
