using UnityEngine;
using UnityEngine.Events;

public class InteractionObject : MonoBehaviour
{
    [SerializeField] private string interactionText = "I'm an interactable object!"; //this is designed to change for each object in the editor
    public UnityEvent onInteract = new UnityEvent(); //new interaction event
    //listeners are added in the unity editor

    public string GetInteractionText() //getter not setter
    {
        return interactionText;
    }

    public void Interact()
    {
        onInteract.Invoke(); //raising the event
        //in this script, subscribers/listeners are handled in the editor, but if I wanted to code subscribers here I would write onInteract.AddListener([name of a function goes here]);
    }
}
//whatever object this class is on needs to have a collider