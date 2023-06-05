using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public static class GameState
{
    public static bool isRunning = false;

    public static string sceneBaseName = "Scene";
    public static int currentScene = 0;
    public static int maxLevels = 3;

    public static void GoToNextScene()
    {
        int nextSceneIndex = GameState.currentScene + 1;
        string nextSceneName = $"{GameState.sceneBaseName}{nextSceneIndex}";

        bool hasNextScene = GameState.maxLevels > nextSceneIndex;

        if (hasNextScene)
        {
            SceneManager.LoadScene(nextSceneName);
            GameState.currentScene++;
        }
        else
        {
            Debug.Log("O jogo acabou");
        }
    }

    public static void RestartScene()
    {
        string currentScene = $"{GameState.sceneBaseName}{GameState.currentScene}";

        SceneManager.LoadScene(currentScene);
    }


    public static void StartRound()
    {
        GameState.isRunning = true;
    }
}

public class GameStateManager : MonoBehaviour
{
    public AudioSource soundGame;

    public Bee player;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GameState.isRunning = true;
        }
    }

    public void Start()
    {
        if (soundGame)
        {
             soundGame.Play();
        }
    }
}