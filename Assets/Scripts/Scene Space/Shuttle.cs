using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shuttle : MonoBehaviour{
    public Animator transition;
    IEnumerator OnCollisionEnter2D(Collision2D coli){
        transition.SetTrigger("start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneName:"Scene Ship");
    }
}
