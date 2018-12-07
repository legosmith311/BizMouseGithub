using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDie : MonoBehaviour {
    public Collider box;
   void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("foot"))
        { 
        Scene scene = SceneManager.GetActiveScene();
        //gets the scene the player is on
        SceneManager.LoadScene(scene.name);
            //sends play to start of the level
        }
    }
}
