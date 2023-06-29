using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{
   [Header("Computer ON/OFF")]
   public bool lightsOn = true;
   public float radius = 2.5f;
   public Light lights;

   [Header("Computer Assign Things")]
   public PlayerScript player;
   [SerializeField] private GameObject ComputerUI;
   [SerializeField] private int showComputerUIFor = 5;

   [Header("Sounds")]
   public AudioClip objectiveCompletedSound;
   public AudioSource audioSource;

   private void Awake() {
    lights = GetComponent<Light>();
   }

   private void Update() {
    if(Vector3.Distance(transform.position, player.transform.position) < radius) {
        if(Input.GetKeyDown("q")) {
            StartCoroutine(ShowComputerUI());
            lightsOn = false;
            lights.intensity = 0;
            //objective complete
            Objectives_Complete.occurrence.GetObjectivesDone(true, true, false, false);
            //sound effect
            audioSource.PlayOneShot(objectiveCompletedSound);
        }
    }
   }

   IEnumerator ShowComputerUI() {
    ComputerUI.SetActive(true);
    yield return new WaitForSeconds(showComputerUIFor);
    ComputerUI.SetActive(false);
   }
}
