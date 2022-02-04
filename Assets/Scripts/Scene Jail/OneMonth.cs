using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OneMonth : MonoBehaviour{
    // Start is called before the first frame update
    IEnumerator Start(){
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName:"Scene Jail");
    }

    // Update is called once per frame
    void Update(){
        
    }
}
