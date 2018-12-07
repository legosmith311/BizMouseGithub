using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    public string NextZone;
    // Use this for initialization
    void OnTriggerEnter2D(Collider2D other)
    {
        //print("collides with something");
        if(other.name == "Player")
        {
            print("collides with win");
            SceneManager.LoadScene(NextZone);
        }
    }
}
