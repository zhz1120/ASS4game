using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaRestriction : MonoBehaviour
{
    public GameObject respawnPoint;

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = respawnPoint.transform.position;
        }
    }
}
