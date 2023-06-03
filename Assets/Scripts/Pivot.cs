using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot : MonoBehaviour
{
    GameObject bee;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Bee bee = gameObject.GetComponent<Bee>();
       // Debug.Log(bee?.transform);
    
      Bee bee = GameObject.FindObjectOfType<Bee>();

       // Debug.Log(bee?.transform.ToString());

    }
}
