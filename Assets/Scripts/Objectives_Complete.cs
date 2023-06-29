using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objectives_Complete : MonoBehaviour
{
    [Header("Objectives to Complete")]
    public Text objective1;
    public Text objective2;
    public Text objective3;
    public Text objective4;

    public static Objectives_Complete occurrence;

    private void Awake() {
        occurrence = this;
    }

    public void GetObjectivesDone(bool obj1, bool obj2, bool obj3, bool obj4) {
        if (obj1 == true) {
            objective1.text = "1. Pick up the key";
            objective1.color = Color.green;
        }
        else {
            objective1.text = "1. Find the key to open the gate";
            objective1.color = Color.white;
        }

        if (obj2 == true) {
            objective2.text = "2. Computer is offline";
            objective2.color = Color.green;
        }
        else {
            objective2.text = "2. Turn off the computer protection system";
            objective2.color = Color.white;
        }

        if (obj3 == true) {
            objective3.text = "3. Generator is offline";
            objective3.color = Color.green;
        }
        else {
            objective3.text = "3. Turn off the generators";
            objective3.color = Color.white;
        }

        if (obj4 == true) {
            objective4.text = "4. Complete mission";
            objective4.color = Color.green;
        }
        else {
            objective4.text = "4. Find your car and run away from this dangerous place";
            objective4.color = Color.white;
        }
    }
}
