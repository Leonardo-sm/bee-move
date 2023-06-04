using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : MonoBehaviour
{
    // public float speed = 5f;
    public Rigidbody2D rb2D;
    public float initialBeeForce = 200f;
    public float boostForce = 0.01f;

    private Vector2 directionForce;
    private readonly float GravityScaleFactor = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        rb2D.AddForce(new Vector2(initialBeeForce, 0));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       rb2D.gravityScale = Mathf.Max(rb2D.gravityScale - Time.fixedDeltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       rb2D.gravityScale = GravityScaleFactor;

        if (collision.gameObject.name == "DirectionModifier")
        {
            Debug.Log("Colidiu com o modificador");

           DirectionModifier mod = collision.gameObject.GetComponent<DirectionModifier>();

           Vector2 direction =  mod.GetDirection();

          //  directionForce = direction * (initialBeeForce + boostForce);

            rb2D.AddForce(direction * initialBeeForce);
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
