using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : MonoBehaviour
{
    // public float speed = 5f;
    public Rigidbody2D rb2D;
    public float force = 200f;

    // Start is called before the first frame update
    void Start()
    {
        rb2D.AddForce(new Vector2(force, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "DirectionModifier")
        {
            Debug.Log("Colidiu com o modificador");

           DirectionModifier mod = collision.gameObject.GetComponent<DirectionModifier>();

           Vector2 direction =  mod.GetDirection();

            Debug.Log(direction);

            rb2D.AddForce(direction * force);
        }

        if (collision.gameObject.name == "Tilemap")
        {
            Debug.Log("Colidiu com o tilemap");
           // Destroy(gameObject);
        }
    }

    void Death()
    {
        // [todo] invocar metodo do pivot que reseta o mapa

        Destroy(this);
    }
}
