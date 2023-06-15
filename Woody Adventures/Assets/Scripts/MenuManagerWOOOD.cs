using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManagerWOOOD : MonoBehaviour
{
    public GameObject optionsMenu;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Check whether it's active / inactive 
            optionsMenu.SetActive(false);
            Timer.timerIsRunning = true;
            Time.timeScale = 1;
            AudioListener.pause = false;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Check whether it's active / inactive 
            optionsMenu.SetActive(true);
            Timer.timerIsRunning = false;
            Time.timeScale = 0;
            AudioListener.pause = true;
        }
    }
}
