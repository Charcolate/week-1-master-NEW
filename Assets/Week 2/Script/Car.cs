using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    float acceleration;
    float steering;
    public float forwardSpeed = 500;
    public float steeringSpeed = 100;
    Rigidbody2D rigidbody;
    public float maxSpeed = 500;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        acceleration = Input.GetAxis("Vertical");
        steering = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rigidbody.AddTorque(steering * -steeringSpeed * Time.deltaTime);
        Vector2 force = transform.up * acceleration * forwardSpeed * Time.deltaTime;
        if (rigidbody.velocity.magnitude < maxSpeed)
        {
rigidbody.AddForce(force);
        }
        
    }
}
