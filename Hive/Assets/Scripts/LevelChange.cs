using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelChange : MonoBehaviour
{
    //Method to change the scene, as well as the turn.
    //Notably interacts with StaticVariableScript to keep track of the turn count.
public void OnButtonPress(int sceneToChange)
    {
        //If turn is even, then it is the "expedition" phase. If it is odd, then it is the "nest management" phase.
        if (StaticVariableScript.turn%2 == 0)
        {

            {
                if (StaticVariableScript.warriors <= 0 || FoodResourceScript.food <= 0)
                {
                    Debug.Log("Game over!");
                }
            }

            Debug.Log("Even - Expedition Phase");
            //StaticVariableScript.farms.Add(1);
            foreach (int farm in StaticVariableScript.farms)
            {
                FoodResourceScript.food++;
            }

            //FoodResourceScript.food++;
            Debug.Log("Food: " + FoodResourceScript.food);
        }
        else {
            Debug.Log("Odd - Nest Phase");
            Debug.Log("Food: " + FoodResourceScript.food);
            StaticVariableScript.gameTurn++; //The gameTurn variable is the turn displayed "in-game," where every two "turns" is technically one turn.
        }
        StaticVariableScript.turn++;
        SceneManager.LoadScene(sceneToChange);

        Debug.Log("Turn is: " + StaticVariableScript.gameTurn);
    }
}
