using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Used to change scenes
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //In order to change scenes
    public void LoadOpenWorld()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadFighting()
    {
        SceneManager.LoadScene(2);
    }

    //To quit the game 
    public void QuitGame()
    {
        Application.Quit();
        //Add debug log if tried to quit in unity editor
    }
}
