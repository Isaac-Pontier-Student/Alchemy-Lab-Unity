using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private float maxDistance = 2.0f;
    [SerializeField] private Text interactableName; //this is to be set in the editor
    private InteractionObject targetInteraction; //InteractionObject script reference used to determine if we're looking at an object with an interaction script

    // Update is called once per frame
    void Update()
    {
        Vector3 origin = Camera.main.transform.position;
        Vector3 direction = Camera.main.transform.forward;
        RaycastHit raycastHit = new RaycastHit();
        string interactionText = "";
        targetInteraction = null; //dictates that we skip the null check "if (targetInteraction)"

        if (Physics.Raycast(origin, direction, out raycastHit, maxDistance)) //null check, only sets objectName if raycast hits something
        {
            targetInteraction = raycastHit.collider.gameObject.GetComponent<InteractionObject>(); //raycast only finds the collider, so we find that collider's
            //... gameObject, then get the InteractionObject script from that
        }

        if (targetInteraction)
        {
            interactionText = targetInteraction.GetInteractionText();
        }   
        SetInteractableNameText(interactionText);
    }

    private void SetInteractableNameText(string newText)
    {
        if (interactableName) //makes sure a text element is being used
        {
            interactableName.text = newText;
        }
    }

    public void TryInteract()
    {
        if (targetInteraction)
        {
            targetInteraction.Interact();
        }
    }    
}
