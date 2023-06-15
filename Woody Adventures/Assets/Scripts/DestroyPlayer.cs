using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyPlayer : MonoBehaviour
{
    private void Start()
    {
        if (Player.Instance) Destroy(Player.Instance.gameObject);
    }
}