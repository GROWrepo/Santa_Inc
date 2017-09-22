using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler, IDragHandler, IEndDragHandler {
    public Item contains;
    bool drag;
    public InventoryManager IM;
    // Use this for initialization
    private void Awake()
    {
        contains = null;
        drag = false;
        IM = InventoryManager.getInstance();
    }
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (drag)
        {
            this.gameObject.transform.Find("Image").gameObject.GetComponent<Transform>().position = Input.mousePosition;
        }
	}
    void setContains(Item item)
    {
        this.contains = item;
        this.gameObject.transform.Find("Image").gameObject.GetComponent<Image>().sprite = item.getImage();
        if(this.contains.getType() == TYPE_ITEM.EXPENDABLES)
        {
            this.gameObject.transform.Find("Number").gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.transform.Find("Number").gameObject.SetActive(false);
        }
    }
    Item getContains()
    {
        return this.contains;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        IM.setCurrentSlot(this.gameObject);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        IM.resetCurrentSlot();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(this.contains != null)
        {
            this.drag = true;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if(contains != null)
        {
            IM.setCurrent(IM.getIndex(this));
            this.gameObject.transform.Find("Image").gameObject.GetComponent<Transform>().position = Input.mousePosition;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (IM.getCurrentSlot() != null)
        {
            IM.swapSlots(IM.getIndex(IM.getCurrentSlot().GetComponent<ItemSlot>()));
        }
    }
    public void startDrag(Item item)
    {
        if(this.contains != null)
        {
            drag = true;
        }
    }
}
