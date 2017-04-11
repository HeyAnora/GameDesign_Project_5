using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceResolution : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        Screen.SetResolution(1080, 1080,false);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Screen.fullScreen)
        {
            Screen.SetResolution(1080, 1080, false);
        }
	}
}
