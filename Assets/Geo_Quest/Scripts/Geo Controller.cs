using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    public string variableOne = "Hello";
    string variableTwo = "World";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        Debug.Log(variableOne+variableTwo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
