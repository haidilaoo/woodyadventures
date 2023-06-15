using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime = 120f;
    public TMP_Text timer;
    public static bool timerIsRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
        currentTime = startingTime;

    }



    // Update is called once per frame
    void Update()
    {

        if (timerIsRunning)
        {
            if (currentTime > 0) 
            {
                currentTime -= 1 * Time.deltaTime;
        
                timer.text = currentTime.ToString("0"); // to round the value and update text //timer.text will update text on component called Timer
            }
            else
            {
            SceneManager.LoadScene("Ending"); // load ending scene when time is up
            currentTime = 0; //so that it will not go beyond 0 to neg numbers
            timerIsRunning = false;
            }
            //else
            //{
            //    if ()
            //}
            
        }
       
    }
}
