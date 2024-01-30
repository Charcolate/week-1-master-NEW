using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterMelt : MonoBehaviour
{
    //adjecting the speed of the butter opacity decreasing speed
    public float dimspeed = 0.1f;

    //check if the steak is touching the butter
    private bool isTouchingSteak = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isTouchingSteak)
        {
            //lower the opacity of the butter
            SpriteRenderer butterRenderer = GetComponent<SpriteRenderer>();
            Color butterColor = butterRenderer.color;
            butterColor.a -= dimspeed * Time.deltaTime;

            //set the updated colour to be the now original butter colour
            butterRenderer.color = butterColor;
        }

        //check if the steak has entered the area of the butter
        void OntriggerEnter2D (Collider2D collision)
        {
            if (collision.CompareTag ("Steak"))
            {
                isTouchingSteak=true;
            }
        }

        //check is the steak has left the area of the butter 
        void OnTriggerExit2D (Collider2D collision)
        {
            if (collision.CompareTag("steak"))
            {
                isTouchingSteak =false;
            }
        }

    }
}
