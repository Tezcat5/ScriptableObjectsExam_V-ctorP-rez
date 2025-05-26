using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemArmadura : MonoBehaviour
{
    public ScriptableItem itemInfo;

    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        if (itemInfo != null && spriteRenderer != null)
        {
            spriteRenderer.sprite = itemInfo.itemSprite;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        InventoryManager.instance.AddItem(itemInfo);
        Destroy(gameObject);
    }
}