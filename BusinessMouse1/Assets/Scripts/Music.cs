using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour {
    public AudioClip NormalMusic;
    public AudioSource MusicSource;
    public AudioClip MenuMusic;
    public AudioSource MenuSource;
    public AudioClip FailedMusic;
    public AudioSource FailedSource;
    public static string zone = "menu";
    Scene CurrentScene;
    // Use this for initialization
    void Start () {
        if(zone == "menu")
        {
            MenuSource.PlayOneShot(MenuMusic, 1);
        }
        if (zone == "gameover")
        {
            FailedSource.PlayOneShot(FailedMusic, 1);
        }
        if (zone == "normal")
        {
            MusicSource.PlayOneShot(NormalMusic, 1);
        }
    }
	
}
