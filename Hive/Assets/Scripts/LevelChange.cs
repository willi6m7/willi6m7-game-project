using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelChange : MonoBehaviour
{

    int alertCooldown = 5;
    public Text txt_WinLose;

    public void Start()
    {
        txt_WinLose = GetComponent<Text>();
    }

    //Method to change the scene, as well as the turn.
    //Notably interacts with StaticVariableScript to keep track of the turn count.
    public void OnButtonPress(int sceneToChange)
    {
        //If turn is even, then it is the "expedition" phase. If it is odd, then it is the "nest management" phase.
        if (StaticVariableScript.turn%2 == 0)
        {
            

            Debug.Log("Even - Expedition Phase");

            //Collect food
            foreach (int farm in StaticVariableScript.farms)
            {
                FoodResourceScript.food++;
            }

            //FoodResourceScript.food++;
            Debug.Log("Food: " + FoodResourceScript.food);
        }
        //Nest Phase
        else {
            Debug.Log("Odd - Nest Phase");
            Debug.Log("Food: " + FoodResourceScript.food);

            //Alert attack functionality
            if (StaticVariableScript.alertLevel >= 5)
            {
                if(StaticVariableScript.warriors <= 10){
                    FoodResourceScript.food -= 20;
                    StaticVariableScript.alertLevel = 0;
                    Debug.Log("Attack: Plundered food");
                }
                else
                {
                    StaticVariableScript.warriors -= 10;
                    StaticVariableScript.alertLevel = 0;
                    Debug.Log("Attack: Fended Off");
                }
            }

            //Alert level functionality
            if (alertCooldown == 5)
            {
                if (FoodResourceScript.food >= 20)
                {
                    StaticVariableScript.alertLevel++;
                    alertCooldown = 0;
                }
                else if(FoodResourceScript.food >= 40){
                    StaticVariableScript.alertLevel++;
                    alertCooldown = 1;
                }
                else if (FoodResourceScript.food >= 60)
                {
                    StaticVariableScript.alertLevel++;
                    alertCooldown = 2;
                }
                else if (FoodResourceScript.food >= 80)
                {
                    StaticVariableScript.alertLevel++;
                    alertCooldown = 3;
                }
            }

            //Game over functionality
            if (FoodResourceScript.food < 0)
            {
                Debug.Log("Game over!");
                //txt_WinLose.text = "You Lose!";
            }

            if (FoodResourceScript.food >= 100)
            {
                Debug.Log("Victory!");
                //txt_WinLose.text = "You Win!";
            }

            StaticVariableScript.gameTurn++; //The gameTurn variable is the turn displayed "in-game," where every two "turns" is technically one turn.
        }
        alertCooldown++;
        StaticVariableScript.turn++;
        SceneManager.LoadScene(sceneToChange);

        Debug.Log("Turn is: " + StaticVariableScript.gameTurn);
    }
}
