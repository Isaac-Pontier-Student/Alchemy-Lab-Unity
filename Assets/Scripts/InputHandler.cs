using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    FirstPersonCamera firstPersonCamera;
    CharacterMovement characterMovement;

    // Start is called before the first frame update
    void Start()
    {
        firstPersonCamera = GetComponent<FirstPersonCamera>();
        characterMovement = GetComponent<CharacterMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        //print("InputHandler update");
        HandleCameraInput();
        HandleMoveInput();
    }

    void HandleCameraInput() //why not just put these in Update without special functions
    {
        firstPersonCamera.AddXAxisInput(Input.GetAxis("Mouse Y") * Time.deltaTime);
        firstPersonCamera.AddYAxisInput(Input.GetAxis("Mouse X") * Time.deltaTime);
    }

    void HandleMoveInput()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float rightInput = Input.GetAxis("Horizontal");
        characterMovement.AddMoveInput(forwardInput, rightInput);
    }
}