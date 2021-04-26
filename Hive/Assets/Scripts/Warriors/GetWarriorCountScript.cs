using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetWarriorCountScript : MonoBehaviour
{
    public Text txt_WarriorCount;

    public void Start()
    {
        txt_WarriorCount = GetComponent<Text>();
    }

    public void Update()
    {
        txt_WarriorCount.text = StaticVariableScript.warriors.ToString() + " Warrior Drones Available";
        if (StaticVariableScript.warriors < 0)
        {
            StaticVariableScript.warriors = 0;
        }
    }
}
