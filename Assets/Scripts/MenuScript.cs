using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        //SceneManager.GetActiveScene().buildIndex + 1
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    // public void InfoScene()
    // {
    //     SceneManager.LoadScene(5);
    // }
    // public void ReturnMain()
    // {
    //     SceneManager.LoadScene(0);
    // }
}
