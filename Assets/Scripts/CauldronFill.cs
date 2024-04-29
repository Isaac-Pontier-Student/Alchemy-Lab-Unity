using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauldronFill : MonoBehaviour
{
    private int fillCount = 0;
    public GameObject[] fillLiquids = new GameObject[4];
    //private bool fillable = false;

    public void Fill()
    {
        //if (fillable)
        
            if(fillCount < fillLiquids.Length)
            {
                 fillLiquids[fillCount].SetActive(true);
                 fillCount++;
                 //fillable = false;
            }
        
    }

    /*public void ResetFillable()
    {
        fillable = true;
    } */

    //if it's been filled never, fill with benzene. if filled once already, fill with sap. If twice, fill with chloric acid. if thrice, turn into final potion.
}
