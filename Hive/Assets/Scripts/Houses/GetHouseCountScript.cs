using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetHouseCountScript : MonoBehaviour
{
    public Text txt_HouseCount;

    public void Start()
    {
        txt_HouseCount = GetComponent<Text>();
    }

    public void Update()
    {
        txt_HouseCount.text = StaticVariableScript.houses.Count.ToString() + " Housing Chambers";
    }
}
