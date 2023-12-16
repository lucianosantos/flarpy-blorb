using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float flapStrength;
    public bool isBirdAlive = true;

    public Rigidbody2D RigidBody;
    public LogicManager logic;
    public SoundManager soundManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!isBirdAlive)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            RigidBody.velocity = Vector2.up * flapStrength;
            soundManager.Play("WingFlap");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Die();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If the Bird hits the OffscreenTrigger, it should die
        if (collision.gameObject.tag == "Offscreen")
        {
            Die();
        }
    }
    private void Die()
    {
        isBirdAlive = false;
        logic.gameOver();
    }
}
