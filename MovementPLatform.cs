using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPLatform : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField]private float speed;
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector3(horizontalInput* speed, body.velocity.y, 0);

        if(horizontalInput > 0.01f)
        
            transform.localScale = Vector3.one;
        else if ( horizontalInput < -0.01)
            transform.localScale = new Vector3(-1f,1f,1f);
        anim.SetBool("Walk", horizontalInput != 0);
    }
}
