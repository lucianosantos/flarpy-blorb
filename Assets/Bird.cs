using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float flapStrength;
    public bool isBirdAlive = true;

    public Rigidbody2D RigidBody;
    public LogicManager logic;

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
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isBirdAlive = false;
        logic.gameOver();
    }
}
