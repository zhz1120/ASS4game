using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishPointScript : MonoBehaviour
{
    public Image finishImage;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player reached the finish point!");
            // 在这里执行您希望在玩家到达终点时触发的操作，例如加载新关卡或显示游戏胜利画面
            finishImage.enabled = true;
        }
    }
}
