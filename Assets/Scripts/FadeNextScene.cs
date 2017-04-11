using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeNextScene : MonoBehaviour
{
    [SerializeField]
    private Fader fade;
    [SerializeField]
    private float waitTime;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(nextScene());
    }

    private IEnumerator nextScene()
    {
        yield return new WaitForSeconds(waitTime);
        fade.beginFade(1);
        yield return new WaitForSeconds(fade.fadeSpeed);
        SceneManager.LoadScene(1);
    }
}
