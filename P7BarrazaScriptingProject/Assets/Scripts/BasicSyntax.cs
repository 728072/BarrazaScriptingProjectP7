using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BasicSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 5f)
        {
            Debug.Log("Im about to hit the ground!");
        }
    }
}
