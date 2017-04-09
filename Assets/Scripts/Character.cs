using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string approach = "Space: Talk";
    public string greeting; 
    public string[] buttonText;
    public string[] answerText;

    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
   
}
