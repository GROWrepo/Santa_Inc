using UnityEngine;
using System.Collections;

public enum ItemType {MANA, HEALTH};

public class Item : MonoBehaviour 
{
    /// <summary>
    /// The current item type
    /// </summary>
    public ItemType type;

    /// <summary>
    /// The item's neutral sprite
    /// </summary>
    public Sprite spriteNeutral;

    /// <summary>
    /// The item's highlighted sprite
    /// </summary>
    public Sprite spriteHighlighted;

    /// <summary>
    /// The max amount of times the item can stack
    /// </summary>
    public int maxSize;

    public string itemName;

    public string description;

    /// <summary>
    /// Uses the item
    /// </summary>
    public void Use()
    {
        switch (type) //Checks which kind of item this is
        {
            case ItemType.MANA:
                Debug.Log("I just used a mana potion");
                break;
            case ItemType.HEALTH:
                Debug.Log("I just used a health potion");
                break;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.SendMessage("getItem", this.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.SendMessage("lostItem");
        }
    }

    public string GetTooltip()
    {

        string newLine = string.Empty; //Resets the new line

        if (description != string.Empty) //Creates a newline if the item has a description, this is done to makes sure that the headline and the describion isn't on the same line
        {
            newLine = "\n";
        }

        //Returns the formattet string
        return string.Format("<color=red><size=16>{0}</size></color><size=14><i><color=lime>" + newLine + "{1}</color></i></size>", itemName, description);
    }

}
