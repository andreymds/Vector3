using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addForce : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject target;

    Vector3 direction, velocity, targetPosition;

    public float speed = 5;

    Vector3 desired_velocity, steering_velocity;
    public float mass = 10;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        targetPosition = target.transform.position;
        
        direction= (targetPosition-transform.position).normalized;
        desired_velocity = direction * speed;

        steering_velocity = desired_velocity - velocity;
        steering_velocity /= mass;

        velocity += steering_velocity;
        rb.velocity = velocity;
    }
}
