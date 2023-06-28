using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    private float time;
    public float intervalTimeEnemy;
    public float platformSizeInX;

    public Transform positionEnemy;
    public GameObject createEnemyYellow;
    public GameObject createEnemyBlack;


    void Start()
    {

    }

    void Update()
    {

        time += Time.deltaTime;

        if (time >= intervalTimeEnemy)
        {
            Vector3 randomPosition = positionEnemy.position;

            randomPosition.x = Random.Range(-platformSizeInX, platformSizeInX);
            positionEnemy.position = randomPosition;

            int enemyRandom = Random.Range(0, 2);

            if (enemyRandom == 1)
            {
                CreateEnemy(createEnemyYellow);
            }
            else
            {
                CreateEnemy(createEnemyBlack);
            }

            time = 0;
        }

    }

    public void CreateEnemy(GameObject enemy)
    {
        Instantiate(enemy, positionEnemy.position, positionEnemy.rotation);
    }



}
