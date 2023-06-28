using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMissileEnemy : MonoBehaviour
{
    private float time;
    public float delayMissile;
    public Transform positionMissile;
    public GameObject missile;


    void Start()
    {

    }


    void Update()
    {
        time += Time.deltaTime;

        if (time >= delayMissile)
        {
            Instantiate(missile, positionMissile.position, positionMissile.rotation);
            time = 0;
        }

    }
}
