using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauldronInteractions : MonoBehaviour
{
    public GameObject[] objectives = new GameObject[4]; //used for the objectives
    
    public void ObjectiveComplete(int counter)
    {
        
        if (counter == 0)
        {
            //complete objective 2 and unlock the sap (take out current unlocking in OnInteract event)
        }
        else if (counter == 1)
        {
            //complete objective 5 and unlock the chloric acid
        }
        else if (counter == 2)
        {
            //complete objective 8 and unlock the bone marrow
        }
        else
        {
            //complete objective 10 and allow for shrink potion taking
        }
    }
}
