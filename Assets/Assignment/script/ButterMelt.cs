using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterMelt : MonoBehaviour
{

    //set the speed for the opacity decreasing
    public float dimSpeed = 0.1f;

    //state for checking if the steak is touching the butter
    private bool isTouchingSteak = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check if the steak is touching the butter
        if (isTouchingSteak)
        {
            //lower the opacity of the butter
            SpriteRenderer butterRenderer = GetComponent<SpriteRenderer>();
            Color butterColour = butterRenderer.color;
            butterColour.a -= dimSpeed * Time.deltaTime;

            //set the new opacity of the butter the new original butter opacity
            butterRenderer.color = butterColour; 
        }

    }

    //check is the steak enters the area of the butter
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Steak"))
        {
            isTouchingSteak = true;
        }
    }

    //check if the steak leaves the area of the butter
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Steak"))
        {
            isTouchingSteak = false;
        }
    }
}
