using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeOnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
