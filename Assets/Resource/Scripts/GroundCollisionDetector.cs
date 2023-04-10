using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisionDetector : MonoBehaviour
{   
    [SerializeField] private string groundTag = "GWall" ;// 在 Unity 检查器中设置地面的标签
    private SpriteRenderer spriteRenderer;
    private PlayerController1 playerController;
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        spriteRenderer=GetComponent<SpriteRenderer>(); 
        playerController = FindObjectOfType<PlayerController1>();
        if (collision.gameObject.CompareTag(groundTag))
        {
            TriggerEffect();
        }
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        spriteRenderer=GetComponent<SpriteRenderer>(); 
        playerController = FindObjectOfType<PlayerController1>();
        if (collision.gameObject.CompareTag(groundTag))
        {
            TriggerEffect();
        }
        
    }


    private void TriggerEffect()
    {
        if(spriteRenderer.color == Color.black){
            playerController.moveSpeed = 10f;
        }else if(spriteRenderer.color == Color.white){
            playerController.moveSpeed = 2f;
        }
        Debug.Log("角色已经接触到地面，触发效果");
    }
}
