using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGMovement : MonoBehaviour
{
    [SerializeField]private float speed;
    private Rigidbody2D body;
    private Vector2 moveDirection;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        ProcessInputs();
    }
    private void FixedUpdate()
    {
        move();
    }
    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY);


    }
    void move()
    {
        body.velocity = new Vector2(moveDirection.x * speed , moveDirection.y * speed);
    }
}
