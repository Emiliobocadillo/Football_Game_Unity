using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Load Scene
    public void PlayLevel1()
    {
        SceneManager.LoadScene("Level-1");  
    }

    // public void PlayLevel1()
    // {
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  
    // }

    public void PlayLevel2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);  
    }

    public void PlayLevel3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);  
    }


    //Quit Game
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player Has Quit The Game");
    }
}
