using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool OnInvulnerable;
    public float durationInvulnerable;
    private float timeInvulnerable;
    public int pointLife;

    public int scorePlayer;
    public Vector2 platformSize;
    public float speed;
    private Vector3 move;
    private Vector3 nextPost;

    [Space]
    public Transform positionExplosion;
    public GameObject Explosion;


    public delegate void DelLifePlayerHandler();
    public static DelLifePlayerHandler onEventLifePlayer;
    public static DelLifePlayerHandler onEventPlayerDead;


    void Start()
    {
        
    }




    void Update()
    {

        if (OnInvulnerable)
        {
            timeInvulnerable += Time.deltaTime;


            if (timeInvulnerable >= durationInvulnerable)
            {
                timeInvulnerable = 0;
                OnInvulnerable = false;
            }

        }


       




        move.x = Input.GetAxisRaw("Horizontal");
        move.z = Input.GetAxisRaw("Vertical");

        transform.Translate(move.normalized * speed * Time.deltaTime);

        nextPost = transform.position;
        nextPost.x = Mathf.Clamp(nextPost.x, -platformSize.x, platformSize.x);
        nextPost.z = Mathf.Clamp(nextPost.z, -platformSize.y, platformSize.y);

        transform.position = nextPost;

    }



    private void OnTriggerEnter(Collider other)
    {
        if (!OnInvulnerable)
        {
            pointLife--;
            onEventLifePlayer.Invoke();

            if (pointLife <= 0)
            {
                onEventPlayerDead.Invoke();
                Instantiate(Explosion, positionExplosion.position, positionExplosion.rotation);
                Destroy(this.gameObject);
            }



            OnInvulnerable = true;
        }  
    }







}
