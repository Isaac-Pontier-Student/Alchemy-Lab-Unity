using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauldronInteractions : MonoBehaviour
{
    public Objective[] objectives = new Objective[4]; //used for the objectives
    public InteractionObject[] unlockObjects = new InteractionObject[4]; //used for the objects to unlock
    private int counter = 0;

    public void ObjectiveComplete() //call this on interaction with cauldron
    {
        objectives[counter].CompleteObjective();
        unlockObjects[counter].enabled = true;
        counter++;
    }
}
