using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{

    public float missileDuration;
    public float speed;
    private float time;
    void Start()
    {

    }



    void Update()
    {
        transform.Translate(Vector3.forward.normalized * speed * Time.deltaTime,Space.Self);

        time += Time.deltaTime;

        if(time>= missileDuration)
        {
            Destroy(this.gameObject);
        }

    }
}
