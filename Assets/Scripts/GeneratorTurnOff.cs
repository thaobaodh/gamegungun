using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorTurnOff : MonoBehaviour
{
    [Header("Generator Lights and button")]
    public GameObject greenLight;
    public GameObject redLight;
    public bool button; 

    [Header("Generator Sound Effects and radius")]
    private float radius = 2f;
    public PlayerScript player;
    public Animator anim;
    public AudioSource audioSource;

    [Header("Sounds")]
    public AudioClip objectiveCompletedSound;


    private void Awake() {
        button = false;
        audioSource = GetComponent<AudioSource>();
    }

    private void Update() {
        if(Input.GetKeyDown("q") && Vector3.Distance(transform.position, player.transform.position) < radius) {
            button = true;
            anim.enabled = false;
            greenLight.SetActive(false);
            redLight.SetActive(true);
            audioSource.Stop();
            Objectives_Complete.occurrence.GetObjectivesDone(true, true, true, false);
            //sound obj
            audioSource.PlayOneShot(objectiveCompletedSound);
        } else if(button == false) {
            greenLight.SetActive(true);
            redLight.SetActive(false);
        }
    }
}
