using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Used to change scenes
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //In order to change scenes
    public static void LoadOpenWorld()
    {
        SceneManager.LoadScene(1);
    }

    public static void LoadFighting()
    {
        SceneManager.LoadScene(2);
    }

    public static void LoadGameOver()
    {
        SceneManager.LoadScene(3);
    }

    //To quit the game 
    public static void QuitGame()
    {
        Application.Quit();
        //Debug log quit
    }
}
