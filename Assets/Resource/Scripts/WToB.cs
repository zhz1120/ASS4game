using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WToB : MonoBehaviour
{ 
    private bool isWhite = false; // Set initial color to black
    // Start is called before the first frame update
    private SpriteRenderer spriteRenderer;
    private void Start()
    {
        spriteRenderer=GetComponent<SpriteRenderer>();   
       
    }

    // Update is called once per frame
    private void Update()
    {
         if (Input.GetKeyDown(KeyCode.X))
        {
            // Toggle color between black and white
          isWhite = !isWhite;
            if (isWhite)
            {
                spriteRenderer.color = Color.black;
            }
            else
            {
                spriteRenderer.color = Color.white;
            }
    }
}
}
