using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {

	// Go to menu once credits are over
	void Start () {
        Invoke("GoToMenu", 15f);
	}
	
	// rolling credits functionality
	void Update () {
        transform.Translate(Vector2.up * 1 * Time.deltaTime);
    }
    void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
        Music.zone = "menu";
    }
}
