using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisionDetector : MonoBehaviour
{   
    [SerializeField] private string groundTag = "GWall" ;// 在 Unity 检查器中设置地面的标签
    private SpriteRenderer spriteRenderer;
    private PlayerController1 playerController;
    //小球接触地面判断
    private void OnCollisionEnter2D(Collision2D collision)
    {
        spriteRenderer=GetComponent<SpriteRenderer>(); 
        playerController = FindObjectOfType<PlayerController1>();
        if (collision.gameObject.CompareTag(groundTag))
        {
            TriggerEffect();
        }
        
    }
    //小球停留地面判断
    private void OnCollisionStay2D(Collision2D collision)
    {
        spriteRenderer=GetComponent<SpriteRenderer>(); 
        playerController = FindObjectOfType<PlayerController1>();
        if (collision.gameObject.CompareTag(groundTag))
        {
            TriggerEffect();
        }
        
    }

    //小球不同颜色碰到地面会加速或者减速
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
