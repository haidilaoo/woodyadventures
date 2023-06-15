
using UnityEngine;
using System;
using TMPro;
using UnityEngine.SceneManagement;

public class InventoryUI : MonoBehaviour
{
    

    private TextMeshProUGUI woodText;
    private int MAX = 5;

    // Start is called before the first frame update
    void Start()
    {
        woodText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateDiamondText(PlayerInventory playerInventory)
    {
        woodText.text = playerInventory.NumberOfWood.ToString();

        if (Convert.ToInt32(woodText.text) == MAX)
        {         
            SceneManager.LoadScene("House built"); // load next scene when 10 wood collected
            Timer.timerIsRunning = false; // stops timer when you rch house scence/win
        }
    }

     
}

