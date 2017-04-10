//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ZombieController : MonoBehaviour
//{
//    private float speed;
//    private Vector2 targetPos;


//    private bool isCasting = true;
//    //raycasts
//    //private RaycastHit2D hitUp;
//    //private RaycastHit2D hitDown;
//    //private RaycastHit2D hitLeft;
//    //private RaycastHit2D hitRight;


//    // Use this for initialization
//    void Start ()
//    {
//        targetPos = transform.position; 
//	}
	
//	// Update is called once per frame
//	void Update ()
//    {
//        //if (isCasting == true)
//        //{
//        //    //hitUp = Physics2D.Raycast(transform.position, Vector2.up);
//        //    //hitDown = Physics2D.Raycast(transform.position, Vector2.down);
//        //    //hitLeft = Physics2D.Raycast(transform.position, Vector2.left);
//        //    //hitRight = Physics2D.Raycast(transform.position, Vector2.right);

//        //    if (hitUp.collider.gameObject.tag == "Target")
//        //    {
//        //        isCasting = false; 
//        //    }
//        //}

//        float step = speed * Time.deltaTime;
//        transform.position = Vector2.MoveTowards(transform.position, targetPos, step);
//	}
//}
