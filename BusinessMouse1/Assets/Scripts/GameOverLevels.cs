using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverLevels : MonoBehaviour
{
    public Button Retry;
    public Button Menu;
    public Button Quit;
    Scene failedlevel;
    private void Start()
    {
        Button btn1 = Retry.GetComponent<Button>();
        btn1.onClick.AddListener(RetryLevel);
        Button btn2 = Menu.GetComponent<Button>();
        btn2.onClick.AddListener(LoadMenu);
        Button btn3 = Quit.GetComponent<Button>();
        btn3.onClick.AddListener(QuitGame);
    }
    void RetryLevel()
    {
        Music.zone = "normal";
        LevelTimer.Timer = 60;
        SceneManager.LoadScene(LevelTimer.LastScene);
    }
    void LoadMenu()
    {
        Music.zone = "menu";
        print(Music.zone);
        SceneManager.LoadScene("Menu");
    }
    void QuitGame()
    {
        Application.Quit();
    }

}
