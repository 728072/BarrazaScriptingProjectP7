using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    void Update()
    {
        Debug.Log("Update Time :" + Time.deltaTime);
    }
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate Time :" + Time.deltaTime);
    }
}
