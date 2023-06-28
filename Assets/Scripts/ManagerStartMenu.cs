using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerStartMenu : MonoBehaviour
{
    public ParticleSystem particle;
    public AudioSource soundMenu;

    void Start()
    {
        particle.Play();
        soundMenu.Play();
    }


    void Update()
    {
        
    }


    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }



}
