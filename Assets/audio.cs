using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    public AudioSource listener;
    public bool liga = true;
     void Start()
    {
        listener = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Controller.som == true)
        {
            GetComponent<AudioSource>().enabled = true;
        }
        else
        {
            GetComponent<AudioSource>().enabled = false;
        }
    }

    
}
