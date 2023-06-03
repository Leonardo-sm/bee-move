using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionModifier : MonoBehaviour
{
    private readonly string directionModifierChildNAme = "Direction";

    public Vector2 GetDirection()
    {
        Transform childTransform = gameObject.transform.Find(directionModifierChildNAme);

        if (childTransform != null)
        {
            GameObject childGameObject = childTransform.gameObject;

            return childGameObject.transform.position - gameObject.transform.position;
        }

        return new Vector2();
    }
}