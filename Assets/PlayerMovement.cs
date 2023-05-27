using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5;
    public Rigidbody2D rb;
    public Animator anim;

    Vector2 movement;

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //if(Input.GetKey(KeyCode.LeftShift))
        //{
        //    anim.SetBool("IsRunning?", true);
        //    moveSpeed = 5;
        //}
        //else if (Input.GetKeyUp(KeyCode.LeftShift))
        //{
        //    anim.SetBool("IsRunning?", false);
        //    moveSpeed = 3;
        //}

        if (movement.x != 0 || movement.y != 0)
        {
            anim.SetFloat("Vertical", movement.y);
            anim.SetFloat("Horizontal", movement.x);
        }
        anim.SetFloat("Speed", movement.sqrMagnitude);
    }

    //public void OnCollisionEnter2D(Collision2D collision)
    //{
    //    anim.SetBool("HitObject?", true);
    //}

    //public void OnCollisionExit2D(Collision2D collision)
    //{
    //    anim.SetBool("HitObject?", false);
    //}

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
