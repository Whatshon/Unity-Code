using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField]private LayerMask platformlayerMask;

    private Rigidbody2D body;
    private Animator anim;
    private bool grounded;
    private BoxCollider2D boxCollider2d;
    private int horizontalInput;
    private int rotatiion;
    [SerializeField]private float attackcd;
    private float cdtimer = Mathf.Infinity;
    private Transform aimTransform;
    

    private void Awake()
    {
        //rigigbody
        body = GetComponent<Rigidbody2D>();
        //animation
        anim = GetComponent<Animator>();
        boxCollider2d = GetComponent<BoxCollider2D>();
        aimTransform = transform.Find("Staff");
    }
    

    private void Update()
    {
        
        //movement
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);
        //keybind. you know what i mean
        //left right
        if (horizontalInput > 0.01f)
            transform.localScale = new Vector3(0.5f, 0.5f, 1);
        else if (Input.GetKey(KeyCode.A))
            transform.localScale = new Vector3(-0.5f, 0.5f, 1);
        //jump
        if (isGrounded() && Input.GetKey(KeyCode.W) )
            body.velocity = new Vector2(body.velocity.x, speed);
        if (isGrounded() && Input.GetKey(KeyCode.Space))
            body.velocity = new Vector2(body.velocity.x, speed);


            //animation update

         anim.SetBool("Run", horizontalInput != 0);
    }
    private void jump()
    {
        body.velocity = new Vector2(body.velocity.x, speed);
        anim.SetTrigger("Jump");
    }

    private bool isGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0, Vector2.down, 0.1f, platformlayerMask);
        Debug.Log(raycastHit.collider);
        return raycastHit.collider != null;
    }
    public bool canAttack()
    {
        return horizontalInput == 0 && isGrounded();
    }
}

