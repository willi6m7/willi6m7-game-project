using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneScript : MonoBehaviour
{
    public GameObject CutsceneCamera;
    public GameObject MainCamera;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSequence());
    }

    IEnumerator StartSequence()
    {
        CutsceneCamera.SetActive(true);
        MainCamera.SetActive(false);
        yield return new WaitForSeconds(3);
        MainCamera.SetActive(true);
        CutsceneCamera.SetActive(false);
    }
}