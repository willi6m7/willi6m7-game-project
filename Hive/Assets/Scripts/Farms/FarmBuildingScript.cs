using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FarmBuildingScript : MonoBehaviour
{

    
    public void OnButtonPress()
    {
        if (FoodResourceScript.food >= 10)
        {
            StaticVariableScript.farms.Add(1);
            FoodResourceScript.food -= 10;
            Debug.Log("Farms: Enough Food!");
        }
        else
        {
            Debug.Log("Farms: Not enough food!");
        }
    }
}
