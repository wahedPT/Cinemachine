using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed, playerJump,playerRadius;
    Rigidbody2D rb;
    public bool facingRight;
    public bool isGrounded;
    public LayerMask layerMask;
    public int jumps, maxnoOfjumps;
    public Transform GroundCheck;
    float xinput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        facingRight = true;
       // isGrounded = true;
    }



    void Start()
    {
        jumps = maxnoOfjumps;
    }

    // Update is called once per frame
    void Update()
    {
        if(isGrounded)
        {
            jumps = maxnoOfjumps;

            if (Input.GetButtonDown("Jump") && jumps > 0)
            {
                rb.velocity = Vector2.up * playerJump;
                maxnoOfjumps -= 1;
            }
            if (Input.GetButtonDown("Jump") && jumps == 0 && isGrounded == true)
            {
                rb.velocity = Vector2.up * playerJump;
                //maxnoOfjumps = -1;
            }

            //if(Input.GetKeyDown(KeyCode.Space))
            //{
            //    rb.velocity = Vector2.up * playerJump;

            //}
        }
        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, playerRadius, layerMask);
       // Debug.Log(isGrounded);
        xinput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xinput * Speed, rb.velocity.y);


        if (facingRight==false&&xinput>0)
        {
            Flip();
        }
        else if(facingRight == true && xinput < 0)
        {
            Flip();
        }

       
    }
    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0, 180.0f, 0);
    }

    public void superJump()
    {
        rb.velocity = Vector2.up * playerJump*1.20f;
    }
}
