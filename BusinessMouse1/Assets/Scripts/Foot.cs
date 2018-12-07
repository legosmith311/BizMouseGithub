using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foot : MonoBehaviour {

    // Use this for initialization
    public int direction = -5;
    private void Start()
    {
        //switch the direction the foot is moving every few seconds
        InvokeRepeating("SwitchDirection", 0f, 1.5f);
    }
    void Update () {
        transform.Translate(Vector2.up * direction * Time.deltaTime);
    }
    void SwitchDirection()
    {
        if (direction == 5)
        {
            direction = -5;
        }
        else
            direction = 5;
    }
}
