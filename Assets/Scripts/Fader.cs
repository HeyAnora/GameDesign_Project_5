using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Fader : MonoBehaviour
{
    public Texture2D fadeOutTexture;
    public float fadeSpeed = 0.8f;

    private int drawDepth = -1000;
    private float alpha = 1.0f;
    private int fadeDir = -1; //direction of fade: in =-1, out = 1 

    void OnGUI()
    {
        //fade out/in alpha value using a direction, a speed and time.deltatime.
        alpha += fadeDir * fadeSpeed * Time.deltaTime;
        //force the number between 0 and 1 (GUI uses alpha values between 0 and 1) 
        alpha = Mathf.Clamp01(alpha);

        //set color of GUI. All coor values remain the same and the Alpha is set to the alpha variable
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);        //set the alpha value
        GUI.depth = drawDepth;                                                      //make the black texture render on top
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture);  //draw texture to fit entire screen
    }

    //sets fadeDir to the direction parameter making the screen fade in if -1 and out if 1
    public float beginFade(int direction)
    {
        fadeDir = direction;
        return (fadeSpeed); //return fadespeed so its easy to time load level
    }


    void Start()
    {
        beginFade(-1);   //call the fade in function 
    }
}