using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour{
    public Player player;
    public float x;
    public float y;
    IEnumerator OnCollisionEnter2D(Collision2D coli){
        yield return new WaitForSeconds(0.05f);
        player.TP(y,x);
    }
}
