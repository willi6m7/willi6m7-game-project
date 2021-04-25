using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseBuildingScript : MonoBehaviour
{
    public void OnButtonPress()
    {
        if (FoodResourceScript.food >= 10)
        {
            StaticVariableScript.houses.Add(1);
            FoodResourceScript.food -= 10;
            Debug.Log("Houses: Enough Food!");
        }
        else
        {
            Debug.Log("Houses: Not enough food!");
        }
    }
}
