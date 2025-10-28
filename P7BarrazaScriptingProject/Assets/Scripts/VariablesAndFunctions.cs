using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    public int myInt = 6;
    // Start is called before the first frame update
    void Start()
    {
        // running int variable
        myInt = MultiplyByTwo(myInt);
        // displaying results
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {

    }
    // creating function to multiply by two
    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 7;
        return result;
    }

}
