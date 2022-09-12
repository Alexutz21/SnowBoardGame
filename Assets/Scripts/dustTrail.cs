using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustParticles;


    void OnCollisionEnter2D(Collision2D other)
    { //we can do it like this with if / else if / else if or
        if (other.gameObject.tag == "Ground")
        {
            dustParticles.Play();
        }
        else if (other.gameObject.tag == "Ground2")
        {
            dustParticles.Play();
        }
        else if (other.gameObject.tag == "Ground3")
        {
            dustParticles.Play();
        }
    }
    void OnCollisionExit2D(Collision2D other)
    { //we can do it more simple like this with || OR
        if (other.gameObject.tag != "Ground" || other.gameObject.tag != "Ground2"
        || other.gameObject.tag != "Ground3")
        {
            dustParticles.Stop();
        }

    }





}
