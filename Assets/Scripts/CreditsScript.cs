using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScript : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
        //SceneManager.GetActiveScene().buildIndex + 1
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
