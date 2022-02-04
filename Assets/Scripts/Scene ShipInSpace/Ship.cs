using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Ship : MonoBehaviour{
    public InfoOverlayController info;
    public Rigidbody2D rig2d;
    public CinemachineVirtualCamera vcam;
    public ParticleSystem par;
    NoiseSettings set;
    public AudioSource jet;
    public DialogueController dialgcl;
    void Awake() {
        rig2d=transform.GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start(){
        set=vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_NoiseProfile;
        vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_NoiseProfile=null;
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow)){
            info.Close();
            info.Show("Release Key to Jump!");
        }
        if(Input.GetKeyUp(KeyCode.Space)||Input.GetKeyUp(KeyCode.W)||Input.GetKeyUp(KeyCode.UpArrow)){
            info.Close();
            rig2d.velocity=Vector2.left*5;
            vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_NoiseProfile=set;
            par.Play();
            jet.Play();
            dialgcl.LoadSceneAfter("1MonthLater");
            dialgcl.DialogueContent(DialogueLoader.LoadDialogue("ep5"));
        }
    }
}
