using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private Vector2 newPos;

    private GameObject targetObject;

    [SerializeField]
    private Mouse mouseScript; 

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Human")
        {
            newPos = other.transform.position;
            targetObject = other.gameObject;
        }
        else if (other.gameObject.tag == "Brain")
        {
            newPos = other.transform.position;
            targetObject = other.gameObject;
        }

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Human")
        {
            newPos = other.transform.position;
            targetObject = other.gameObject;
        }
        else if (other.gameObject.tag == "Brain")
        {
            newPos = other.transform.position;
            targetObject = other.gameObject;
        }

    }

	// Use this for initialization
	void Start ()
    {
        mouseScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Mouse>(); 
        newPos = transform.position; 
	}
	
	// Update is called once per frame
	void Update ()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, newPos, step);

        if (targetObject != null && transform.position == targetObject.transform.position)
        {
            StartCoroutine(Eat());
            
        }
	}

    private IEnumerator Eat()
    {
        if (targetObject.tag == "Brain")
        {
            mouseScript.placedBrain = null;
        }
        if (targetObject.tag == "Human")
        {
            mouseScript.totalHumans -= 1;
        }
        Destroy(targetObject);
        targetObject = null;
        yield return null;
    }
}
