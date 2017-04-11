using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pylon : MonoBehaviour
{
    public Animator anim;
    public int swordPuzzleNumber;
    public bool visited = false; 

    public string approach; 
	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();	
	}
}
