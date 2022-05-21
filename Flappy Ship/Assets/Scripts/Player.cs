using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    
    [SerializeField] private GameManager gameManager;
    [SerializeField] private SoundManager soundManager;

    private float jumpAmount = 100f;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
            soundManager.PlaySound("jump");
        }

        transform.eulerAngles = new Vector3(0, 0, rigidBody.velocity.y * 0.2f); //rotates ship as it falls
    }

    void Jump()
    {
        rigidBody.velocity = Vector2.up * jumpAmount;
    } 

    void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
        soundManager.PlaySound("death");
    }
}
