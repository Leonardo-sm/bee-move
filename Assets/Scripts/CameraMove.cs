using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    [Range(0f, 1f)]
    public float followDelay = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z);

        Vector3 newPosition = Vector3.Lerp(transform.position, player.position, 1 - Mathf.Pow(followDelay, Time.fixedDeltaTime));

        newPosition.z = -10;

        transform.position = newPosition;
    }
}
