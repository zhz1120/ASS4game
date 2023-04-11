using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallEnableCheck : MonoBehaviour
{
    // Start is called before the first frame update
     private SpriteRenderer spriteRenderer;
    private ColliderToggle collidertoggle;
    private PlayerController1 playerController;
    void Start()
    {
        spriteRenderer=GetComponent<SpriteRenderer>(); 
        collidertoggle = FindObjectOfType<ColliderToggle>();
        playerController = FindObjectOfType<PlayerController1>();
    }

    // Update is called once per frame
    void Update()
    {
    //    if (Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.LeftShift)){
    //    if(spriteRenderer != null && playerController != null){
    //    if(spriteRenderer.color ==  playerController.Pcolor){
    //         collidertoggle.ToggleCollider(true);
    //         spriteRenderer.enabled = true;
    //     }
    //     }else{
    //       collidertoggle.ToggleCollider(false);
    //       spriteRenderer.enabled = false; 
    //     }
    // }
    if(spriteRenderer != null && playerController != null){
        if(spriteRenderer.color ==  playerController.Pcolor){
             collidertoggle.ToggleCollider(true);
             spriteRenderer.enabled = true;
         }else{
           collidertoggle.ToggleCollider(false);
           spriteRenderer.enabled = false; 
        }
    }
    }
    
}
