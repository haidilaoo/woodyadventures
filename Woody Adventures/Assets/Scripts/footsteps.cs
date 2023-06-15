using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    public AudioSource footstepsSound;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || 
            Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.RightArrow))
        {

                footstepsSound.enabled = true;
              
        }
        else
        {
            footstepsSound.enabled = false;
          
        }
    }
}