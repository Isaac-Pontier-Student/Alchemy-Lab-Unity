using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //singleton
    public static GameManager instance;

    private void Awake() //awake happens when the script is loaded before the game even starts
    {
        if (instance)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this); //when loading a new scene, we don't want it to destroy our gamemanager gameobject
        }
    }

    public static void LoadScene(string newSceneName) //the "static" allows multiple gamemanagers across scenes to work the same
    {
        SceneManager.LoadScene(newSceneName); //can use integer index or string scene name
    }

    public static void Quit()
    {
        Application.Quit();
    }
}
