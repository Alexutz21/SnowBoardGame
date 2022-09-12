using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishLine3 : MonoBehaviour
{
    [SerializeField] float nextSceneDelay = 1f;
    [SerializeField] ParticleSystem FinishEffect3;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            FinishEffect3.Play();
            GetComponent<AudioSource>().Play();
            Invoke("NextScene", nextSceneDelay);
        }
    }
    void NextScene()
    {
        SceneManager.LoadScene(4);
    }
}
