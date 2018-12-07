using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DomScript : MonoBehaviour
{
    //public GameObject Player;
    public int moveSpeed = 5;
    public bool jump = true;
    public int jumpheight = 10;
    public float xMove = 0;
    public float yMove = 0;
    public Rigidbody2D rb2d;
    public BoxCollider2D col;
    public float distToGround;
    public LayerMask groundLayer;
    public float ySpeed1;
    public float ySpeed2;
    public bool facingRight;
    public GameObject idle;
    public GameObject runRight;
    public AudioClip Running;
    public AudioSource RunningSource;
    public float low = 0.5f;
    public float high = 1f;


    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
        distToGround = col.bounds.extents.y;
        ySpeed1 = rb2d.velocity.y;
        ySpeed2 = ySpeed1;
    }

    void Update()
    //movement
    {//print(jumptimer);
        //xMove = 0;
        //yMove = 0;
        

        jump = IsGrounded();

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            facingRight = false;
            //float vol = Random.Range(low, high);
            //RunningSource.PlayOneShot(Running, vol);
            this.transform.Find("Mouse_Idle_Right").gameObject.SetActive(false);
            this.transform.Find("Mouse_run_Right_0").gameObject.SetActive(false);
            this.transform.Find("Mouse_Idle_Left").gameObject.SetActive(false);
            this.transform.Find("Mouse_run_Left_0").gameObject.SetActive(true);
        }
       else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            facingRight = true;
            this.transform.Find("Mouse_Idle_Right").gameObject.SetActive(false);
            this.transform.Find("Mouse_Idle_Left").gameObject.SetActive(false);
            this.transform.Find("Mouse_run_Left_0").gameObject.SetActive(false);
            this.transform.Find("Mouse_run_Right_0").gameObject.SetActive(true);
            //idle.SetActive(false);
            //idle.enabled = false;
            //runRight.enabled = true;
        }
        else
        {
            if(facingRight)
            {
                this.transform.Find("Mouse_Idle_Right").gameObject.SetActive(true);
                this.transform.Find("Mouse_Idle_Left").gameObject.SetActive(false);
            }
            else
            {
                this.transform.Find("Mouse_Idle_Left").gameObject.SetActive(true);
                this.transform.Find("Mouse_Idle_Right").gameObject.SetActive(false);
            }
            
            this.transform.Find("Mouse_run_Right_0").gameObject.SetActive(false);
            this.transform.Find("Mouse_run_Left_0").gameObject.SetActive(false);
        }




        //jumping
        if (Input.GetKey(KeyCode.Space) && jump) //&& Mathf.Approximately(ySpeed1, ySpeed2))
        {
            print("jumpheight");
            //rb.AddForce(Vector2.up * jumpheight);
            //rb2d.AddForce(0, jumpheight);
            rb2d.velocity = new Vector2(0.0f, jumpheight);
        }

        ySpeed2 = ySpeed1;
        ySpeed1 = rb2d.velocity.y;
        //rigidbody.velocity.y = jumpSpeed;
    }

    
    bool IsGrounded()
    {
        //eturn Physics.Raycast(transform.position, Vector3.down, distToGround + 0.1f);
       
        RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y), -Vector2.up, 0.2f);
        if (hit.collider != null)
        {
            return true;
        }
        RaycastHit2D hit2 = Physics2D.Raycast(new Vector2(transform.position.x - 1f, transform.position.y), -Vector2.up, 0.2f);
        if (hit.collider != null)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    /*
    bool IsGrounded()
    {

        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.0f;

        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        Debug.DrawRay(position, direction, Color.green);
        if (hit.collider != null)
        {
            return true;
        }

        return false;
    }
    */
}

