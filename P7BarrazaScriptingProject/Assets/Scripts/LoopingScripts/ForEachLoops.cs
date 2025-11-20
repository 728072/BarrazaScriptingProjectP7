using UnityEngine;
using System.Collections;

public class ForeachLoop : MonoBehaviour
{
    void Start()
    {
        string[] strings = new string[3];

        strings[0] = "67";
        strings[1] = "41";
        strings[2] = "test";

        foreach (string item in strings)
        {
            print(item);
        }
    }
}