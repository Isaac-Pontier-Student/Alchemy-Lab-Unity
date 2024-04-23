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
        float xAxisInput = Input.GetAxis("Mouse Y"); //mouse y movement is up and down
        float yAxisInput = Input.GetAxis("Mouse X");

        xAxis -= xAxisInput * xAxisTurnRate * Time.deltaTime;
        xAxis = Mathf.Clamp(xAxis, -90.0f, 90.0f); //restricts it to bottom and top
        yAxis += yAxisInput * yAxisTurnRate * Time.deltaTime;

        Quaternion newRotation = Quaternion.Euler(xAxis, yAxis, 0);

        Camera.main.transform.rotation = newRotation;
    }
}
