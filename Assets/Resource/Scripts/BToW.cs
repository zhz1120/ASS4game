using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BToW : MonoBehaviour
{ 
    //private bool isGreen = false; // Set initial color to black
    // Start is called before the first frame update
    private SpriteRenderer spriteRenderer;
    private void Start()
    {
        spriteRenderer=GetComponent<SpriteRenderer>();   
       
    }

    // Update is called once per frame
    private void Update()
    {
    //      if (Input.GetKeyDown(KeyCode.X))
    //     {
    //         // Toggle color between black and white
    //       isGreen = !isGreen;
    //         if (isGreen)
    //         {
    //             spriteRenderer.color = Color.green;
    //         }
    //         else
    //         {
    //             spriteRenderer.color = Color.red;
    //         }
    // }
    spriteRenderer.color = Color.green;
}
}
