using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopAction : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger("chopping");
            Debug.Log("chopping = true");
        }
    }
}
