using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMissile : MonoBehaviour
{
    private float time;
    public float delayMissile;
    public Transform positionMissile;
    public GameObject missile;
 
    public AudioSource SoundShoot;

  
    void Start()
    {

    }


    void Update()
    {



        time += Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && time >= delayMissile)
        {
            SoundShoot.Play();
            Instantiate(missile, positionMissile.position, positionMissile.rotation);
            time = 0;
        }

    }
}
