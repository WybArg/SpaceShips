using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ManagerEndGame : MonoBehaviour
{
    public ParticleSystem particle;
    public AudioSource soundMenu;
    public Text textInfo;
    private int highScore;
    private int sessionScore;

    void Start()
    {
        particle.Play();
        soundMenu.Play();

        highScore = PlayerPrefs.GetInt("highScoreKey");
        sessionScore = PlayerPrefs.GetInt("sessionScoreKey");

        if (sessionScore > highScore)
        {
            PlayerPrefs.SetInt("highScoreKey", sessionScore);
            textInfo.text = "Congratulations you beat the record with " + sessionScore + " points.";
        }
        else
        {
            textInfo.text = "You failed to beat the highest score.";
        }

        PlayerPrefs.SetInt("sessionScoreKey", 0);
        PlayerPrefs.Save();
    }


    void Update()
    {

        
    }
}
