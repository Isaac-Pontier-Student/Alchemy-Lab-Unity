using UnityEngine;
using UnityEngine.Events;

public class InteractionObject : MonoBehaviour
{
    [SerializeField] private string interactionText = "I'm an interactable object!!!!!"; //this is designed to change for each object in the editor
    public UnityEvent onInteract = new UnityEvent(); //new interaction event
    //listeners are added in the unity editor

    public string GetInteractionText() //getter not setter
    {
        return interactionText;
    }

    public void Interact()
    {
        onInteract.Invoke(); //raising the event
    }
}
//whatever object this class is on needs to have a collider