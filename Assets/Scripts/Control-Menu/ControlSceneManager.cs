using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlSceneManager : MonoBehaviour
{
    public void goBack(){
        SceneManager.LoadScene("MainMenuScene");
    }
}
