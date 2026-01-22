using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckState : MonoBehaviour
{
    public GameObject myObject;
    void Start()
    {
        Debug.Log("Activate Self: " + myObject.activeSelf);
        Debug.Log("Activate In Hierarchy: " + myObject.activeInHierarchy);
    }
}
