using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneJailInit : MonoBehaviour{
    public DialogueController dialgcl;
    public MenuController menu;
    void Awake(){
        dialgcl.LoadSceneAfter("Credits");
        dialgcl.DialogueContent(DialogueLoader.LoadDialogue("ep6"));
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            menu.PauseResume();
        }
    }
}
