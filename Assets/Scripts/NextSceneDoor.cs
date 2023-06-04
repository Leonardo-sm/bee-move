using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSceneDoor : MonoBehaviour
{
    private readonly string BEE_GAME_OBJECT_NAME = "Bee";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == BEE_GAME_OBJECT_NAME)
        {
            GameState.GoToNextScene();
        }
    }
}