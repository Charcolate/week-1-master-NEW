using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterMelt : MonoBehaviour
{
    private SpriteRenderer butterRenderer;

   // Start is called before the first frame update
    void Start()
    {
       butterRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //check is the steak enters the area of the butter
    private void OnTriggerEnter2D(Collider2D collision)
    {
        butterRenderer.color = new Color(butterRenderer.color.r, butterRenderer.color.g, butterRenderer.color.g, 0.0f);
    }

    //check if the steak leaves the area of the butter
    private void OnTriggerExit2D(Collider2D collision)
    {
        butterRenderer.color = new Color(butterRenderer.color.r, butterRenderer.color.g, butterRenderer.color.g, 1.0f);
    }
}
