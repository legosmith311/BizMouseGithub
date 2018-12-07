
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private bool grounded = true;
    private bool jump = true;
    private Animator anim;
    private Rigidbody2D rb2d;
    public Transform groundCheck;
    public float jumpForce = 10f;

    // Use this for initialization
    void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
        grounded = true;

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            jump = true;
        }

        if (jump)
        {
            //anim.SetTrigger("Jump");
            rb2d.AddForce(new Vector2(0f, jumpForce));
            jump = false;
        }
    }
}
