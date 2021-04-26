using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class SurfaceEventTrigger : MonoBehaviour
{
    public Flowchart flowchart;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        flowchart.ExecuteBlock("InteractExampleOne");
    }

    public void FightMethod()
    {
        StaticVariableScript.warriors--;
        StaticVariableScript.alertLevel--;
        Debug.Log("Event: Fight - Alert--, Warriors--");
    }
    public void IgnoreMethod()
    {
        StaticVariableScript.warriors += 2;
        StaticVariableScript.alertLevel++;
        Debug.Log("Event: Ignore - Alert++, Warriors+2");
    }
}
