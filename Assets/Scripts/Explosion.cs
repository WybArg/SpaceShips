using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    public float durationExplosion;
    private float time;


    void Start()
    {
        
    }



    void Update()
    {

        time += Time.deltaTime;

       if(time>= durationExplosion)
        {
            Destroy(this.gameObject);
        }


        
    }
}
