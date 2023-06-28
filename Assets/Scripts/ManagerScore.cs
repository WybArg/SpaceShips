using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerScore : MonoBehaviour
{
    private int score;
    private int lifePlayer;
    public Player shipsPlayer;
    public Text textScore;
    public Text textLifePlayer;

  

    void Start()
    {
        lifePlayer = shipsPlayer.pointLife;
        Enemy.onEventScore += AddScore;
        Player.onEventLifePlayer += DecreaseLifePlayer;
        ManagerScene.onEventGameOver += SaveScorePlayer;
    }



    void Update()
    {
        
    }

    public void AddScore(int score)
    {
        this.score += score;
        textScore.text = $"{this.score}";
    }

    public void DecreaseLifePlayer()
    {
        lifePlayer--;
        textLifePlayer.text = $"{lifePlayer}";
    }

    public void SaveScorePlayer()
    {
        PlayerPrefs.SetInt("sessionScoreKey", score);
        PlayerPrefs.Save();
    }

}
