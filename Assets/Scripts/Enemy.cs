using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int score;
    public float enemyDuration;
    public float speed;
    private float time;
    public int lifePoint;
    [Space]
    public bool moveZigZag;
    private float countZigZag;
    public float timeZigZag;
    [Space]
    public Transform positionExplosion;
    public GameObject Explosion;


    public delegate void DelScoreHandler(int score);
    public static DelScoreHandler onEventScore;

    void Start()
    {

    }




    void Update()
    {


        if (moveZigZag)
        {

            countZigZag += Time.deltaTime;

            if (countZigZag <= timeZigZag)
            {
                transform.Translate(new Vector3(1, 0, 1).normalized * speed * Time.deltaTime, Space.Self);
            }
            else
            {
                transform.Translate(new Vector3(-1, 0, 1).normalized * speed * Time.deltaTime, Space.Self);
            }


            if (countZigZag >= timeZigZag * 2)
            {
                countZigZag = 0;
            }


        }
        else
        {
            transform.Translate(Vector3.forward.normalized * speed * Time.deltaTime, Space.Self);
        }


        time += Time.deltaTime;



        if (time >= enemyDuration)
        {
            Destroy(this.gameObject);
        }


    }



    private void OnTriggerEnter(Collider other)
    {
        lifePoint--;

        if (lifePoint <= 0)
        {
            Instantiate(Explosion, positionExplosion.position, positionExplosion.rotation);

            onEventScore.Invoke(score);
            Destroy(this.gameObject);
        }

    }












}
