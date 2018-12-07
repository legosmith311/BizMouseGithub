using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public bool CanJump;
    public bool onGround;
    //register player hitting the ground
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("ground"))
        {
            onGround = true;
            print("onGround: " + onGround);
        }

    }
    //register player leaving the ground
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ground"))
        {
            onGround = false;
            print("onGround: " + onGround);
        }
    }
    void Update()
    {
        //player jump
        if (Input.GetKey(KeyCode.Space))
        {
            //check to see if the player can jump
            if (onGround == true)
            {
                //pushes the player upwards
                GetComponent<Rigidbody>().AddForce(Vector2.up * 100);
            }
            //GetComponent<Rigidbody>().AddForce(Vector2.up * 100);
        }
    }
}
