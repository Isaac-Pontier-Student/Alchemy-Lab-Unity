using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    FirstPersonCamera firstPersonCamera;
    CharacterMovement characterMovement;
    PlayerInteraction playerInteraction;

    // Start is called before the first frame update
    void Start()
    {
        firstPersonCamera = GetComponent<FirstPersonCamera>();
        characterMovement = GetComponent<CharacterMovement>();
        playerInteraction = GetComponent<PlayerInteraction>();
    }

    // Update is called once per frame
    void Update()
    {
        //print("InputHandler update");
        HandleCameraInput();
        HandleMoveInput();
        HandleInteractionInput();
    }

    void HandleCameraInput()
    {
        firstPersonCamera.AddXAxisInput(Input.GetAxis("Mouse Y") * Time.deltaTime);
        firstPersonCamera.AddYAxisInput(Input.GetAxis("Mouse X") * Time.deltaTime);
    }

    void HandleMoveInput()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float rightInput = Input.GetAxis("Horizontal");
        characterMovement.AddMoveInput(forwardInput, rightInput);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            characterMovement.moveSpeed = 8.5f;
        }
        else
        {
            characterMovement.moveSpeed = 5.0f;
        }
    }

    void HandleInteractionInput()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            playerInteraction.TryInteract();
        }
    }    
}
