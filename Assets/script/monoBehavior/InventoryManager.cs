using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventoryManager : MonoBehaviour {
    public List<Item> items;
    public List<ItemSlot> slots;
    public GameObject currentSlot;
    public int max;
    public int current;
    // Use this for initialization
    private void Awake()
    {
        items = new List<Item>();
        slots = new List<ItemSlot>();
        for (int i = 0; i < this.gameObject.transform.Find("slots").childCount; i++)
        {
            slots[i] = this.gameObject.transform.Find("slots").GetChild(i).GetComponent<ItemSlot>();
        }
    }
    void Start()
    {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void setCurrent(GameObject currentSlot)
    {
        this.currentSlot = currentSlot;
    }
    void resetCurrent()
    {
        this.currentSlot = null;
    }
    void initInventory()
    {

    }
    Item getItem(int index)
    {
        return this.items[index];
    }
    Item getItem(string name)
    {
        return this.items[this.items.FindIndex(item => item.name == name)];
    }
}
