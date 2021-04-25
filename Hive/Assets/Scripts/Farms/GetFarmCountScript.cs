using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetFarmCountScript : MonoBehaviour
{
    
    public Text txt_FarmCount;

    public void Start()
    {
        txt_FarmCount = GetComponent<Text>();
    }

    public void Update()
    {
        txt_FarmCount.text = StaticVariableScript.farms.Count.ToString() + " Farming Chambers";
    }

}
