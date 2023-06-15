using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
 public Transform Spawnpoint;
 public GameObject PreFab, PreFab2;
 private bool waitForButton;
 public bool requireButton;
 private bool hasSpawned = false;

 void OnTriggerEnter()
{

        if (requireButton) 
  {
   waitForButton = true;
        return;
  }
}
  void Update()
{
        if(waitForButton && Input.GetButtonDown ("Fire1"))
        {
          if(hasSpawned == false)
         Instantiate(PreFab, Spawnpoint.position, Spawnpoint.rotation);
         Instantiate(PreFab2, Spawnpoint.position, Spawnpoint.rotation);
         hasSpawned = true;
        }
}
}
