using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderToggle : MonoBehaviour
{
    private Collider2D collider2D;

    private void Start()
    {
        collider2D = GetComponent<Collider2D>();
    }

    public void ToggleCollider(bool isEnabled)
    {
        if (collider2D != null)
        {
            collider2D.enabled = isEnabled;
        }
    }
}
