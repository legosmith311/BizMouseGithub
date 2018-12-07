using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour {
    public Button StartGame;
    public Button Credits;
    public Button Quit;
    // Use this for initialization
    void Start () {
        Button btn1 = StartGame.GetComponent<Button>();
        btn1.onClick.AddListener(LoadLevel1);
        Button btn2 = Credits.GetComponent<Button>();
        btn2.onClick.AddListener(LoadCredits);
        Button btn3 = Quit.GetComponent<Button>();
        btn3.onClick.AddListener(QuitGame);
    }
    void LoadLevel1()
    {
        LevelTimer.Timer = 60;
        SceneManager.LoadScene("Level1");
        Music.zone = "normal";
        //print("click registered");
    }
    void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    void QuitGame()
    {
        Application.Quit();
    }

}
