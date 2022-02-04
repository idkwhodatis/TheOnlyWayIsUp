using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneShipInit : MonoBehaviour{
    public DialogueController dialgcl;
    public MenuController menu;
    void Awake(){
        dialgcl.LoadSceneAfter("Scene ShipInSpace");
        dialgcl.DialogueContent(DialogueLoader.LoadDialogue("ep4"));
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            menu.PauseResume();
        }
    }
}
