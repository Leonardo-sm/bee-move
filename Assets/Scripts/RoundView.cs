using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundView : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform childTransform = gameObject.transform.Find("State");

        if (childTransform != null)
        {
            childTransform.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameState.isRunning)
        {
            Transform childTransform = gameObject.transform.Find("State");

            if (childTransform != null)
            {
                childTransform.gameObject.SetActive(true);
            }
        }
    }
}
