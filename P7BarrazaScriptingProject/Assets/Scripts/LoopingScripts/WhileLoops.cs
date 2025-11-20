using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    int cups = 4;
    void Start()
    {
        while (cups <= 1)
        {
            Debug.Log("I have " + cups + " cup left!");
            cups--;
        }
        while (cups > 1)
        {
            Debug.Log("I have " + cups + " cups left!");
            cups--;
        }
    }
}
