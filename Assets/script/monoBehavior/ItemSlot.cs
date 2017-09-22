using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerEnter(PointerEventData eventData)
    {
        this.gameObject.transform.GetComponentInParent<InventoryManager>().gameObject.SendMessage("setCurrent", this.gameObject);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        this.gameObject.transform.GetComponentInParent<InventoryManager>().gameObject.SendMessage("resetCurrent");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }
}
