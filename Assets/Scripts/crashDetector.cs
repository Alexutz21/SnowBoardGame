using UnityEngine;
using UnityEngine.SceneManagement;

public class crashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFXAudio;

    bool hasCrashed = false;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground" && !hasCrashed)
        {
            //Debug.Log("Ouch!!!");
            hasCrashed = true;
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFXAudio);
            Invoke("ReloadScene0", loadDelay);
        }
        else if (other.gameObject.tag == "Ground2" && !hasCrashed)
        {
            hasCrashed = true;
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFXAudio);
            Invoke("ReloadScene1", loadDelay);
        }
        else if (other.gameObject.tag == "Ground3" && !hasCrashed)
        {
            hasCrashed = true;
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFXAudio);
            Invoke("ReloadScene2", loadDelay);
        }
    }
    void ReloadScene0() //method for reloading scene 1
    {
        SceneManager.LoadScene(1);
    }
    void ReloadScene1() //method for reloading scene 2
    {
        SceneManager.LoadScene(2);
    }
    void ReloadScene2() //method for reloading scene 3
    {
        SceneManager.LoadScene(3);
    }


}
