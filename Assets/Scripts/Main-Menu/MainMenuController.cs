using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame(){
        //loads the next scene in the script, level 0
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 ); 

    }

    public void ExitGame(){
        //quits the application
        Application.Quit();
        //for testing purposes
        #if UNITY_EDITOR
        Debug.Log("Game has been quit (Editor does not exit during play mode).");
        #endif

    }

    public void How2Play(){
        //load the scene by the name thus since will be also used in the paused menu
        SceneManager.LoadScene("ControlScene");
        
    }
}
