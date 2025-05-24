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
        // ���� SpriteRenderer �ء���㹩ҡ
        allSprites = new List<SpriteRenderer>(FindObjectsOfType<SpriteRenderer>());
    }

    void UpdateSortingOrders()
    {
        foreach (SpriteRenderer sprite in allSprites)
        {
            // ����˹� Y �ӹǳ Sorting Order (��Ƿ�������ӡ����դ���ҡ����)
            sprite.sortingOrder = Mathf.RoundToInt(sprite.transform.position.z * -100);

int baseSortingOrder = Mathf.RoundToInt(transform.position.z * -100);
    
    // ��� Scale.x �� -1 ��骴�¡�èѴ���§
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

