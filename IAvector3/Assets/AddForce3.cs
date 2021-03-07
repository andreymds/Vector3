using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce3 : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private float thrust = 50;
    public float velocidade;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();        
    }

    void FixedUpdate()
    {
        rb2D.AddForce(transform.right * thrust *velocidade);
    }
}
