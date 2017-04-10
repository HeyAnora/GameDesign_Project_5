using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private float baseSpeed;

    private Rigidbody2D rb;

    [SerializeField]
    private GameObject textPanel;
    [SerializeField]
    private GameObject dialoguePanel;

    [SerializeField]
    private Text[] dialogueText; 

    [SerializeField]
    private Character npcScript;

    private Pylon pylonScript; 

    private Animator anim;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        textPanel = GameObject.Find("TextPanel");
        dialoguePanel = GameObject.Find("DialoguePanel");
        textPanel.SetActive(false);
        dialoguePanel.SetActive(false);

        anim = GetComponent<Animator>();

        baseSpeed = speed; 
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "NPC")
        {
            textPanel.SetActive(true);
            npcScript = other.gameObject.GetComponent<Character>();
            textPanel.GetComponentInChildren<Text>().text = npcScript.approach;

            if (Input.GetKeyDown("space"))
            {
                dialoguePanel.SetActive(true);

                for (int i = 0; i < dialogueText.Length; i++)
                {
                    dialogueText[i].text = npcScript.buttonText[i];
                }

                textPanel.GetComponentInChildren<Text>().text = npcScript.greeting;

                anim.SetTrigger("Talk");
                npcScript.anim.SetTrigger("Talk");
            }
        }

        else if (other.gameObject.tag == "Pylon")
        {
            textPanel.SetActive(true);
            pylonScript = other.gameObject.GetComponent<Pylon>();
            textPanel.GetComponentInChildren<Text>().text = pylonScript.approach;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "NPC")
        {
            if (Input.GetKeyDown("space"))
            {
                dialoguePanel.SetActive(true); 

                for (int i = 0; i < dialogueText.Length; i++)
                {
                    dialogueText[i].text = npcScript.buttonText[i];
                }

                textPanel.GetComponentInChildren<Text>().text = npcScript.greeting;

                anim.SetTrigger("Talk");
                npcScript.anim.SetTrigger("Talk");
            }
        }

       else if (other.gameObject.tag == "Pylon")
        {
            pylonScript.anim.SetTrigger("Stop");
        }
    
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "NPC")
        {
            textPanel.SetActive(false);
            dialoguePanel.SetActive(false);
            anim.SetTrigger("Idle");
            npcScript.anim.SetTrigger("Idle");
        }

        else if (other.gameObject.tag == "Pylon")
        {
            textPanel.SetActive(false);
            pylonScript.anim.SetTrigger("Stop");
        }
    }

    public void Option_1()
    {
        textPanel.GetComponentInChildren<Text>().text = npcScript.answerText[0];
    }

    public void Option_2()
    {
        textPanel.GetComponentInChildren<Text>().text = npcScript.answerText[1];
    }

    public void Option_3()
    {
        textPanel.GetComponentInChildren<Text>().text = npcScript.answerText[2];
    }
    public void Option_4()
    {
        textPanel.GetComponentInChildren<Text>().text = npcScript.answerText[3];
    }

    //void Update()
    //{
    //    if (Input.GetAxis("Horizontal") != 0 && Input.GetAxis("Vertical") != 0)
    //    {
    //        speed = baseSpeed / 2;
    //    }

    //    else speed = baseSpeed;
    //}

    //Physics
	void FixedUpdate ()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

       // Vector3 movement = new Vector2(moveH, moveV);

        // transform.position += movement * speed * Time.deltaTime; 
        rb.velocity = new Vector2(moveH * speed, moveV * speed);
	}

}
