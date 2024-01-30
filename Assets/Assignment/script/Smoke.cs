using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class Smoke : MonoBehaviour
{
    //give it spriterenerer and definetion of when to change opacity
    private SpriteRenderer smokeRenderer;
    private float opacityChangeTimer = 0f;
    private float opacityChangeInterval = 1f;

    // Start is called before the first frame update
    void Start()
    {
        smokeRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        opacityChangeTimer += Time.deltaTime;

        //check if the interval for opacity change has elapsed
        if (opacityChangeTimer >= opacityChangeInterval )
        {
            //reset the timer
            opacityChangeTimer = 0f; 

            if (smokeRenderer.color.a ==1.0f)
            {
                smokeRenderer.color = new Color(smokeRenderer.color.r, smokeRenderer.color.g, smokeRenderer.color.b, 0.5f);
            }
            else
            {
                smokeRenderer.color = new Color(smokeRenderer.color.r, smokeRenderer.color.g, smokeRenderer.color.b, 1.0f);
            }
        }
    }
}
