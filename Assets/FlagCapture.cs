﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagCapture : MonoBehaviour {

    void OnTriggerEnter(Collider hit) {
        if (hit.gameObject.tag == "Player") {
            Application.Quit();
        }
    }
}
