using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishLine2 : MonoBehaviour
{
    [SerializeField] float nextSceneDelay = 1f;
    [SerializeField] ParticleSystem FinishEffect2;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            FinishEffect2.Play();
            GetComponent<AudioSource>().Play();
            Invoke("NextScene", nextSceneDelay);
        }
    }
    void NextScene()
    {
        SceneManager.LoadScene(3);
    }
}
