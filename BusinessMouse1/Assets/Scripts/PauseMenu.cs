using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    // Use this for initialization
    public GameObject PauseMenuObject;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            print("escape pressed");
            if (Time.timeScale == 1)
            {
                //pause game
                Time.timeScale = 0;
                //open pause menu
                PauseMenuObject.SetActive(true);
            }
            else if (Time.timeScale == 0)
            {
                //unpause game
                Time.timeScale = 1;
                //close pause menu
                PauseMenuObject.SetActive(false);
            }
        }
    }
}

