using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class InventoryManager : MonoBehaviour {
    public List<Item> items;
    public List<ItemSlot> slots;
    public GameObject currentSlot;
    public int maxPage;
    public int currentPage;
    public int current;
    public int target;
    private static InventoryManager instance;
    // Use this for initialization
    private void Awake()
    {
        instance = this;
        items = new List<Item>();
        slots = new List<ItemSlot>();
        for (int i = 0; i < 21; i++)
        {
            slots.Add(Instantiate<GameObject>((GameObject)Resources.Load("Pref/Inventory/ItemSlot"), new Vector3((80 * (i%7)) - 240 + 377, 118 - (100 * ((i / 7) + 1)) + 289), Quaternion.identity, this.gameObject.transform.Find("base").Find("slots")).GetComponent<ItemSlot>());
        }
        currentPage = 1;
        maxPage = 1;
    }
    void Start()
    {
        items.Add(new Item("test", TYPE_ITEM.INGREDIENTS, Sprite.Create(Resources.Load("image/communication/testNPC") as Texture2D, new Rect(0,0, (Resources.Load("image/communication/testNPC") as Texture2D).width, (Resources.Load("image/communication/testNPC") as Texture2D).height),Vector2.zero)));
        this.initInventory();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void setCurrentSlot(GameObject currentSlot)
    {
        this.currentSlot = currentSlot;
    }
    public GameObject getCurrentSlot()
    {
        return this.currentSlot;
    }
    public void resetCurrentSlot()
    {
        this.currentSlot = null;
    }
    public void initInventory()
    {
        maxPage = (this.items.Count / 21) + 1;
        for(int i = 0; i < 21 && i < this.items.Count; i++)
        {
            Debug.Log(items[((currentPage - 1) * 21) + i].getName());
            this.slots[items[((currentPage - 1) * 21) + i].getSlot()].SendMessage("setContains", this.items[((currentPage - 1) * 21) + i]);
        }
        this.gameObject.transform.Find("base").Find("page").Find("max").gameObject.GetComponent<Text>().text = maxPage.ToString();
        this.gameObject.transform.Find("base").Find("page").Find("current").gameObject.GetComponent<Text>().text = currentPage.ToString();
    }
    public Item getItem(int index)
    {
        return this.items[index];
    }
    public Item getItem(string name)
    {
        return this.items[this.items.FindIndex(item => item.getName() == name)];
    }
    public List<Item> getItems(TYPE_ITEM itemType)
    {
        return this.items.FindAll(item => item.getType() == itemType);
    }
    public void setCurrent(int currentSlotIndex)
    {
        this.current = currentSlotIndex;
    }
    public void setTarget(int targetSlotIndex)
    {
        this.target = targetSlotIndex;
    }
    public void swapSlots(int target)
    {
        Debug.Log(this.slots[target].contains);
        if (this.slots[target].contains != null)
        {
            ItemSlot tempSlot = this.slots[target];
            Item tempItem = this.items[target];
            this.slots[target] = this.slots[this.current];
            this.slots[this.current] = tempSlot;
            this.items[target].setSlot(this.items[this.current].getSlot());
            this.items[this.current].setSlot(tempItem.getSlot());
        }
        else
        {
            this.slots[target] = this.slots[this.current];
            this.slots[this.current] = null;
            this.items[target].setSlot(this.items[this.current].getSlot());
            this.items.RemoveAt(this.current);
        }
        this.initInventory();
    }
    public static InventoryManager getInstance()
    {
        return instance;
    }
    public int getIndex(ItemSlot slot)
    {
        return this.slots.FindIndex(item => item == slot);
    }
}
