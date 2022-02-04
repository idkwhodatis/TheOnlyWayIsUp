using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguePlat : MonoBehaviour{
    public GameObject dialg;
    public DialogueController dialgcl;
    public Player player;
    bool triggered=false;
    IEnumerator OnCollisionEnter2D(Collision2D coli){
        if(!triggered){
            yield return new WaitForSeconds(0.05f);
            player.TP(66.00679f);
            dialgcl.DialogueContent(DialogueLoader.LoadDialogue("ep3"));
            triggered=true;
        }
    }
}
