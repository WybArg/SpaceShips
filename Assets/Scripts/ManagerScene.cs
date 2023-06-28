using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{
    public Text textTime;
    private float time;
    private float timex;
    private bool OnNextScene = false;

    public delegate void DelGameOverHandler();
    public static DelGameOverHandler onEventGameOver;

    void Start()
    {
        Player.onEventPlayerDead += PlayerDead;
    }


    void Update()
    {
        time += Time.deltaTime;
        textTime.text = $"{(int)time}";


        if (time >= 60)
        {
            onEventGameOver.Invoke();
            OnNextScene = true;
        }

        if (OnNextScene)
        {
            Invoke(nameof(NextScene), 6);
            OnNextScene = false;
        }



    }

    public void PlayerDead()
    {
        onEventGameOver.Invoke();
        OnNextScene = true;
    }


    public void NextScene()
    {
        SceneManager.LoadScene(2);
    }


}
