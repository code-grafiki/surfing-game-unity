using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] float restart;
    [SerializeField] ParticleSystem Fparticle;

    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("FINISHHH!");
        if(other.tag == "Player")
        {
            Fparticle.Play();
            GetComponent<AudioSource>().Play();
            Invoke("SceneReload",restart);
        }  
    }
    
    void SceneReload()
    {
        SceneManager.LoadScene(0);
    }

}
