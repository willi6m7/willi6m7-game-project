using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManpowerResourceScript : MonoBehaviour
{
    public static int manpower = 10; //Manpower resource; can be used for things like expeditions and defending the nest
    public Text txt_ManPowerResource;

    // Start is called before the first frame update
    void Start()
    {
        txt_ManPowerResource = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        txt_ManPowerResource.text = manpower.ToString();
    }
}
