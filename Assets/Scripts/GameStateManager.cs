using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameState
{
    public static bool isRunning = true;

    public static string sceneBaseName = "Scene";
    public static int currentScene = 0;

    public static void GoToNextScene()
    {
        int nextSceneIndex = GameState.currentScene + 1;
        string nextSceneName = $"{GameState.sceneBaseName}{nextSceneIndex}";

        Scene nextScene = SceneManager.GetSceneByName(nextSceneName);

        if (nextScene.IsValid())
        {
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            Debug.Log("O jogo acabou");
        }
    }

    public static void StartRound()
    {
        GameState.isRunning = true;
    }
}

public class GameStateManager : MonoBehaviour
{

}