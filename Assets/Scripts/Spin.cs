using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    float yAxis = 0;
    public float rotationSpeed = 0.2f;

    // Update is called once per frame
    void Update()
    {
        Quaternion newRotation = Quaternion.Euler(0, yAxis, 0);
        transform.rotation = newRotation;
        yAxis+= rotationSpeed;
    }
}
