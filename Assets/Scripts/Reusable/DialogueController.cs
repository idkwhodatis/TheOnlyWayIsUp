using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueController : MonoBehaviour{
    public GameObject dialg;
    public Text nameT;
    public Text contentT;
    Queue<string> names;
    Queue<string> contents;
    bool notEmpty=false;
    public InfoOverlayController info;
    string actAfter="false";
    string actmsg;
    public MenuController menu;
    void Update(){
        if(notEmpty){
            if(Input.GetMouseButtonDown(0)&&menu.NotPaused()){
                nameT.text=names.Dequeue();
                contentT.text=contents.Dequeue();
                if(names.Count==0||contents.Count==0){
                    notEmpty=false;
                    switch(actAfter){
                        case "info":
                            info.Show(actmsg);
                            break;
                        case "scene":
                            SceneManager.LoadScene(sceneName:actmsg);
                            break;

                    }
                }
            }
        }else{
            dialg.SetActive(false);
        }
    }

    public void DialogueContent(Queue<string>[] text){
        names=text[0];
        contents=text[1];
        nameT.text=names.Dequeue();
        contentT.text=contents.Dequeue();
        dialg.SetActive(true);
        notEmpty=true;
    }

    public void ShowInfoAfter(string s){
        actAfter="info";
        actmsg=s;
    }
    public void LoadSceneAfter(string s){
        actAfter="scene";
        actmsg=s;
    }
}
