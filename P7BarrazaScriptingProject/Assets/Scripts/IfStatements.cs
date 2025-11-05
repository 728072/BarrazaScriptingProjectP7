using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class IfStatements : MonoBehaviour
{

    float HotLimit = 90.00f;
    float ColdLimit = 45.00f;
    float newvalue = 100.00f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (newvalue > HotLimit)
        {
            print("Coffee is too hot.");
        }
        else if (newvalue < ColdLimit)
        {
            print("Coffee is too cold.");
        }
        else
        {
            print("Coffee is just right!");
        }

        int subtract = 5;

        if (Input.GetKeyDown(KeyCode.Space))
        {

            float result;
            float v = newvalue - subtract;
            result = v;


        }
    }
}
