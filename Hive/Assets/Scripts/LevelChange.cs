using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelChange : MonoBehaviour
{

    //Method to change the scene.
public void OnButtonPress(int sceneToChange)
    {
        SceneManager.LoadScene(sceneToChange);
        //Debug.Log("Test");
    }
}
