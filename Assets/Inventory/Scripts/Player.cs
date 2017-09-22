using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    
    /// <summary>
    /// The player's movement speed
    /// </summary>
    public float speed;
    public GameObject getItems;

    /// <summary>
    /// A reference to the inventory
    /// </summary>
    public Inventory inventory;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        HandleMovement();

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(getItems != null)
            {
                inventory.AddItem(getItems.GetComponent<Item>()); //Adds the item to the inventory.
            }
        }

    }

    /// <summary>
    /// Handles the players movement
    /// </summary>
    private void HandleMovement()
    {
        //Calculates the players translation so that we will move framerate independent
        float translation = speed * Time.deltaTime;

        //Moves the player
        transform.Translate(new Vector2(Input.GetAxis("Horizontal") * translation, 0));
        //Input.GetAxis("Vertical") * translation - y좌표축 이동 
    }

    /// <summary>
    /// Handles the player's collision
    /// </summary>
    /// <param name="other"></param>
    /// 
    private void getItem(GameObject other)
    {
        getItems = other;
          
    }

    private void lostItem()
    {
        getItems = null;
    }

    
}
