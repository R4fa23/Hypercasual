using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    public AudioListener listener;
    bool liga = true;
     void Start()
    {
        listener = GetComponent<AudioListener>();

    }

    // Update is called once per frame
    void Update()
    {
        if (liga)
        {
            listener.enabled = true;
        }
        else
        {
            listener.enabled = false;
        }
    }

    public void Ligar()
    {
        liga = !liga;
    }
}
