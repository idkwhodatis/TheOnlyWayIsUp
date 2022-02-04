using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoOverlayController : MonoBehaviour{
    public GameObject infoOverlay;
    public Text info;
    bool hasShown=false;
    int counter=0;
    void Update(){
        if(infoOverlay.activeSelf){
            if(counter<3){
                if(Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow)){
                    counter++;
                }
            }else{
                infoOverlay.SetActive(false);
            }
        }
    }
    public void Show(string infomsg){
        if(!hasShown){
            info.text=infomsg;
            infoOverlay.SetActive(true);
            hasShown=true;
        }
    }
    public void Close(){
        infoOverlay.SetActive(false);
        hasShown=false;
    }

}
