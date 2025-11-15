using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Homework3script : MonoBehaviour
{
    public string nextLevel = "Game 1";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");

        switch (collision.tag)
        {
            
                

            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }

        }
    }
}

