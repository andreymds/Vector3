using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed, startWaitTime;
    private float waitTime;
    public Transform[] moveSpot;
    public int spot;

    void Start()
    {
        waitTime = startWaitTime;
        spot = 0;
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpot[spot].position, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, moveSpot[spot].position) < 0.2f)
        {
            if(waitTime <= 0)
            {
                spot++;
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
        if(spot == 5)
        {
            spot = 0;
        }

    }
}
