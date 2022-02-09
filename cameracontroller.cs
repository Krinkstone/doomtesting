using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float clockwise = 100.0f;

    void Start()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKey("down"))
        {
            transform.position -= transform.forward * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, Time.deltaTime * -clockwise, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, Time.deltaTime * clockwise, 0);
        }
    }
}