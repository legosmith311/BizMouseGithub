using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTimer : MonoBehaviour {
    public static int Timer = 30;
    public static string LastScene;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Timedown", 0f, 1f);
        Scene currentScene = SceneManager.GetActiveScene();
        LastScene = currentScene.name;
    }
	void Timedown()
    {
        Timer--;
        print("Timer" + Timer);
    }
    void Update()
    {
        if (Timer == 0)
        {
            print(LastScene);
            Music.zone = "gameover";
            SceneManager.LoadScene("GameOver");
        }
    }
}
