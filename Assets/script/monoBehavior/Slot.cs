using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Slot : MonoBehaviour, IDragHandler
{

    public int number;
    public Item item;

    public void OnDrag(PointerEventData data)
    {
        if (transform.childCount > 0)
            transform.GetChild(0).parent = Inventory.instance.draggingItem;
        Inventory.instance.draggingItem.GetChild(0).position = data.position;
    }

}

