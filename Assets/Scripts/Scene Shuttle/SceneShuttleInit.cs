using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneShuttleInit : MonoBehaviour{
    public DialogueController dialgcl;
    public MenuController menu;
    void Awake(){
        dialgcl.LoadSceneAfter("Scene Space");
        dialgcl.DialogueContent(DialogueLoader.LoadDialogue("ep1"));
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            menu.PauseResume();
        }
    }
}
