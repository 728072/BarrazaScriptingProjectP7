using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControls : MonoBehaviour
{
    public float speed = 10;
    public float turnspeed = 20;

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnspeed * Time.deltaTime;

        transform.Translate(-Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }
}
