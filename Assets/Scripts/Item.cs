using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public ScriptableItem itemInfo;

    private SpriteRenderer spriteRenderer;
    
    void Start()
    {
        spriteRenderer.sprite = itemInfo.itemSprite;
    }
    
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        InventoryManager.instance.AddItem(itemInfo);
        Destroy(gameObject);
    }
}