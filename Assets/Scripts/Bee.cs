using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float constantBeeForce = 200f;
    public float startBeeForce = 100f;
    public float boostForce = 0.01f;

    public float acceleration = 1.05f;

    public float deacceleration = 0.95f;
    public float desiredSpeed = 2f;

    private readonly float GravityScaleFactor = 0.5f;

    public GameObject particlePrefab;

    public AudioSource gameSound;

    private void Start()
    {
        StartCoroutine(SpawnParticleOvertime());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Vector2 direction = new Vector2(startBeeForce, 0);

            if(gameObject.transform.rotation.y == -1)
            {
               direction = new Vector2(-startBeeForce, 0);
            }

            rb2D.AddForce(direction);
        }

        rb2D.gravityScale = Mathf.Max(rb2D.gravityScale - Time.fixedDeltaTime, 0);

        float currentSpeed = Vector2.Distance(Vector2.zero, rb2D.velocity);

        if (currentSpeed >= desiredSpeed)
        {
            rb2D.velocity *= deacceleration;
        }
        else
        {
            rb2D.velocity = rb2D.velocity.normalized * desiredSpeed;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        rb2D.gravityScale = GravityScaleFactor;

        if (collision.gameObject.name == "DirectionModifier")
        {
            DirectionModifier mod = collision.gameObject.GetComponent<DirectionModifier>();

            Vector2 direction = mod.GetDirection();

            if(direction[0] < 0){
                gameObject.transform.Rotate(new Vector3(0f, 180, 0f));
            }

            rb2D.AddForce(direction * constantBeeForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(ColisionTileMap(collision));
    }

    void Death()
    {
        GameState.RestartScene();
    }

    IEnumerator ColisionTileMap(Collision2D collision)
    {
        if (collision.gameObject.name == "Tilemap")
        {
            if (gameSound != null)
            {
                gameSound.Play();
            }
            yield return new WaitForSeconds(0.15f);

            Death();
        }
    }

    public IEnumerator SpawnParticleOvertime()
    {
        while (true) {
            GameObject go = Instantiate(particlePrefab, null);

            go.transform.position = transform.position;

            yield return new WaitForSeconds(0.5f);
        }
    }
}
