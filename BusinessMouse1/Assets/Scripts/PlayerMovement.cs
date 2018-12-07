using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Player;
    public int moveSpeed;
    bool jump = true;
    public int jumpcooldown = 3;
    public int jumpheight = 20;
    public float jumptimer;
    void Update()
    //movement
    
    {//print(jumptimer);
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
    }
}


