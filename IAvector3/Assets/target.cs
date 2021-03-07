using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public Transform moveSpot;
    public float speed;
    Rigidbody2D rb;
    Vector3 direction; 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = new Vector3(1,0,1);
    }
    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveSpot.position, 5);
        //rb.AddForce.;
    }
}
