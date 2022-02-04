using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSpaceInit : MonoBehaviour{
    public DialogueController dialgcl;
    public MenuController menu;
    void Awake(){
        dialgcl.ShowInfoAfter("Use Space/W/Up Arrow to Use Jetpack");
        dialgcl.DialogueContent(DialogueLoader.LoadDialogue("ep2"));
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            menu.PauseResume();
        }
    }
}
