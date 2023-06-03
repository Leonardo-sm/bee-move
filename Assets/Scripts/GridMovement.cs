using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovement : MonoBehaviour
{
    public float rotateSpeed = 10f;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            RotateCounterclockwise();

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            RotateClockwise();
        }
    }

    void RotateClockwise()
    {
        Vector3 rotateDirection = new(0, 0, -1f);

        gameObject.transform.Rotate(rotateSpeed * Time.deltaTime * rotateDirection);
    }

    void RotateCounterclockwise()
    {
        Vector3 rotateDirection = new(0, 0, 1f);

        gameObject.transform.Rotate(rotateSpeed * Time.deltaTime * rotateDirection);
    }
}
