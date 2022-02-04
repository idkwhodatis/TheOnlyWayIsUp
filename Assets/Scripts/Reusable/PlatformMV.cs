using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMV : MonoBehaviour{
    IEnumerator OnCollisionEnter2D(Collision2D coli){
        yield return new WaitForSeconds(0.05f);
        coli.gameObject.transform.SetParent(gameObject.transform,true);
    }
    IEnumerator OnCollisionExit2D(Collision2D coli){
        yield return new WaitForSeconds(0.35f);
        coli.gameObject.transform.parent.DetachChildren();
    }
}
