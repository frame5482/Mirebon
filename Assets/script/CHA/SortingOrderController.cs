using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingOrderController : MonoBehaviour
{

    public List<SpriteRenderer> allSprites = new List<SpriteRenderer>();

    private SpriteRenderer spriteRenderer;
    void Start()
    {
        FindAllUnits();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        UpdateSortingOrders();
    }

    void FindAllUnits()
    {
        // ค้นหา SpriteRenderer ทุกตัวในฉาก
        allSprites = new List<SpriteRenderer>(FindObjectsOfType<SpriteRenderer>());
    }

    void UpdateSortingOrders()
    {
        foreach (SpriteRenderer sprite in allSprites)
        {
            // ใช้ตำแหน่ง Y คำนวณ Sorting Order (ตัวที่อยู่ต่ำกว่ามีค่ามากกว่า)
            sprite.sortingOrder = Mathf.RoundToInt(sprite.transform.position.z * -100);

int baseSortingOrder = Mathf.RoundToInt(transform.position.z * -100);
    
    // ถ้า Scale.x เป็น -1 ให้ชดเชยการจัดเรียง
    if (transform.localScale.x < 0)
    {
        spriteRenderer.sortingOrder = baseSortingOrder - 1; 
    }
    else
    {
        spriteRenderer.sortingOrder = baseSortingOrder;
    }
            }
        }
    }

