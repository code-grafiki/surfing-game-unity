using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] float restart;
    [SerializeField] ParticleSystem Cparticle;
    bool isDed = false;

    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("Crashed!");

        if(other.tag == "Ground" && !isDed )
        {
            isDed = true;
            FindObjectOfType<PlayerController>().DisableControls();
            Cparticle.Play();
            GetComponent<AudioSource>().Play();
            Invoke("SceneReload",restart);
        }
    }

    void SceneReload()
    {
        SceneManager.LoadScene(0);
    }

}
