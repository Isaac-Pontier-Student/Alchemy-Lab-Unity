using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    private float xAxis; //up and down movement
    private float yAxis; //side to side movement
    float xAxisTurnRate = 360.0f;  //sensitivity
    float yAxisTurnRate = 360.0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate() //camera movement always goes here, happens after Update()
    {
        Quaternion newRotation = Quaternion.Euler(xAxis, yAxis, 0);

        Camera.main.transform.rotation = newRotation;
    }

    public void AddXAxisInput(float input)
    {
        xAxis -= input * xAxisTurnRate;
        xAxis = Mathf.Clamp(xAxis, -90.0f, 90.0f); //restricts it to above bottom and below top
    }

    public void AddYAxisInput(float input) 
    {
        yAxis += input * yAxisTurnRate;
    }
}
