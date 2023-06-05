using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionModifier : MonoBehaviour
{
    private readonly string directionModifierChildNAme = "Direction";
    public AudioSource gameSound;

    public Vector2 GetDirection()
    {
        if (!GameState.isRunning)
        {
            return new Vector2();
        }

        if(gameSound != null)
        {
             gameSound.Play();
        }

        Transform childTransform = gameObject.transform.Find(directionModifierChildNAme);

        if (childTransform != null)
        {
            GameObject childGameObject = childTransform.gameObject;

            return childGameObject.transform.position - gameObject.transform.position;
        }

        return new Vector2();
    }
}