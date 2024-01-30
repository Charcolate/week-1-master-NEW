using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteakMove : MonoBehaviour
{
    //give the steak basic states for moving around
    Vector2 direction;
    public float maxSpeed = 500;
    Rigidbody2D rb;
    public float forwardSpeed = 500;
    public float steeringSpeed = 100;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.AddForce(direction * forwardSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Whoops! Almost fell out of pan!");
    }
}
 