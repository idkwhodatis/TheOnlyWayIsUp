using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed=10;
    public Rigidbody2D rig2d;
    public Vector2 spawn;
    public GameObject dialg;
    Vector2 pos;
    public AudioSource jetpack;
    void Awake() {
        rig2d=transform.GetComponent<Rigidbody2D>();
    }

    void Start(){
        spawn=transform.position;
    }

    void Update() {
        pos=transform.position;
        if(pos.y<=-20){
            TP(spawn.y);
        }else{
            if(!dialg.activeSelf){
                if(Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow)){
                    rig2d.velocity=Vector2.up*speed;
                    jetpack.Play();
                }
            }
        }

        // pos.x+=speed*Input.GetAxis("Horizontal")*Time.deltaTime;
        // transform.position=pos;
    }

    public void TP(float y,float x=0){
        pos=transform.position;
        pos.y=y;
        pos.x=x;
        transform.position=pos;
    }
}