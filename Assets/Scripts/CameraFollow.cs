using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    private GameObject target;
    private Vector3 targetPos;
    private Vector3 playerPos;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float distanceThresh;
	// Use this for initialization
	void Start ()
    {
        target = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        playerPos = new Vector3(target.transform.position.x,target.transform.position.y,transform.position.z);

        float distance_x = Mathf.Abs(transform.position.x - playerPos.x);
        float distance_y = Mathf.Abs(transform.position.y - playerPos.y);

       
        if (distance_x > distanceThresh || distance_y > distanceThresh)
        {
            if (distance_x > distanceThresh && distance_y > distanceThresh)
            {
                targetPos = new Vector3(playerPos.x, playerPos.y, transform.position.z);
            }

            else if (distance_x > distanceThresh && distance_y <= distanceThresh)
            {
                targetPos = new Vector3(playerPos.x, transform.position.y, transform.position.z);
            }

            else if (distance_y > distanceThresh && distance_x <= distanceThresh)
            {
                targetPos = new Vector3(transform.position.x, playerPos.y, transform.position.z);
            }

            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetPos, step);
        }
        
	}

   //void LateUpdate()
   // {
   //     transform.position = new Vector3(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y), Mathf.Round(transform.position.z));
   // }
}
