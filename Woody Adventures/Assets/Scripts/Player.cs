using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Stores the current singleton instance
    private static Player instance;

    // Read-only public access
    public static Player Instance => instance;

    private void Awake()
    {
        // Does another instance already exist?
        if (instance && instance != this)
        {
            // Destroy myself
            Destroy(gameObject);
            return;
        }

        // Otherwise store my reference and make me DontDestroyOnLoad
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
