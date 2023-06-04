using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public float despawnCooldown = 2f;
    public float currentCooldown = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentCooldown += Time.deltaTime;

        if(currentCooldown > despawnCooldown){
            Destroy(gameObject);
        }
    }
}
