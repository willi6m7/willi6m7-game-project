using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodResourceScript : MonoBehaviour
{
    public static int food; //Food resource; can be used for things like feeding manpower and winning the game
    public Text txt_FoodResource;
    

    void Start()
    {
        txt_FoodResource = GetComponent<Text>();
        
    }
    void Update()
    {
        txt_FoodResource.text = food.ToString();
    }
}
