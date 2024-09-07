﻿/*
* Kayden Miller
* CGE 401 Prototype 01
* Script to add score when player crosses the trigger zone
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddScore : MonoBehaviour
{
    private bool triggered = false;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
            Destroy(gameObject);
        }
    }
}
