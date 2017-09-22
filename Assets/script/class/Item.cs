using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item {
    private string name;
    private TYPE_ITEM type;
    private Sprite image;
    private int slot;

    public Item(string name, TYPE_ITEM type, Sprite image)
    {
        this.name = name;
        this.type = type;
        this.image = image;
    }
    public Item(string name, Sprite image)
    {
        this.name = name;
        this.type = TYPE_ITEM.INGREDIENTS;
        this.image = image;
    }
    #region getter
    public string getName()
    {
        return this.name;
    }
    public TYPE_ITEM getType()
    {
        return this.type;
    }
    public Sprite getImage()
    {
        return this.image;
    }
    public int getSlot()
    {
        return this.slot;
    }
    #endregion

    #region setter
    public void setName(string name)
    {
        this.name = name;
    }
    public void setType(TYPE_ITEM type)
    {
        this.type = type;
    }
    public void setImage(Sprite image)
    {
        this.image = image;
    }
    public void setSlot(int slot)
    {
        this.slot = slot;
    }
    #endregion
}
