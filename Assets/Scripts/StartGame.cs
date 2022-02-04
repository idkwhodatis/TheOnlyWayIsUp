using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour{
    public Button startBtn;
    public Button exitBtn;
    void Start(){
        GameObject.FindGameObjectWithTag("Music").GetComponent<BackgroundMusicPlayer>().StopMusic();
        startBtn.onClick.AddListener(Starts);
        exitBtn.onClick.AddListener(Exits);
    }
    public void Starts(){
        GameObject.FindGameObjectWithTag("Music").GetComponent<BackgroundMusicPlayer>().PlayMusic();
        SceneManager.LoadScene(sceneName:"Scene Shuttle");
    }
    public void Exits(){
        Application.Quit();
    }
}
