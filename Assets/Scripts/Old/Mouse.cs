using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Mouse : MonoBehaviour
{
    [SerializeField]
    private Vector2 mousePosition;

    [SerializeField]
    private GameObject brain;

    public GameObject placedBrain;

    public int totalHumans;

    [SerializeField]
    private int totalBrains;

    private Scene scene;

    // Use this for initialization
    void Start ()
    {
        totalHumans = GameObject.FindGameObjectsWithTag("Human").Length;
        scene = SceneManager.GetActiveScene();
    }
	
	// Update is called once per frame
	void Update ()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePosition;

        if (Input.GetMouseButtonDown(0) && placedBrain == null && totalBrains > 0) //left click
        {
            PlaceBrain(); 
        }

        if (totalHumans <= 0)
        {

            SceneManager.LoadScene(scene.buildIndex + 1);
        }

        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(scene.buildIndex);
        }
	}

    private void PlaceBrain()
    {
        totalBrains--;
        placedBrain = Instantiate(brain, new Vector2(transform.position.x, transform.position.y),Quaternion.identity);
    }
}
