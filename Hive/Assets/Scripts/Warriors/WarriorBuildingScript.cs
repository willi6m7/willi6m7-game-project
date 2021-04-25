using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorBuildingScript : MonoBehaviour
{
    public void OnButtonPress()
    {
        if (FoodResourceScript.food >= 1)
        {
            if (StaticVariableScript.houses.Count >= StaticVariableScript.warriors)
            {
                StaticVariableScript.warriors++;
                FoodResourceScript.food -= 1;
                Debug.Log("Warriors: Enough Food!");
            }
            else
            {
                Debug.Log("Warriors: Not enough room!");
            }
        }
        else
        {
            Debug.Log("Warriors: Not enough food!");
        }
    }
}
