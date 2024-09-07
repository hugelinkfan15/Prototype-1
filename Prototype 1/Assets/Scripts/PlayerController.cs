/*
* Kayden Miller
* CGE 401 Prototype 01
* Script to control the player vehicle
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    public float forwardInput;
    public float horizantalInput;
    // Update is called once per frame
    void Update()
    {

        forwardInput = Input.GetAxis("Vertical");
        horizantalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizantalInput);
    }
}
