<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    float speed;
    public bool isGrounded;
    public bool isOnRope;

    Rigidbody2D rigid;
    Vector3 movement;
    public STATUS_PLAYER SP;

	// Use this for initialization
	void Start ()
    {
        isGrounded = false;

        speed = 5.0f;
        SP = STATUS_PLAYER.STANDING;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (SP == STATUS_PLAYER.STANDING)
        {
            this.gameObject.GetComponent<Collider2D>().isTrigger = false;
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;

            if (Input.GetKey(KeyCode.A))
            {
                SP = STATUS_PLAYER.WALKING;
            }
            if (Input.GetKey(KeyCode.D))
            {
                SP = STATUS_PLAYER.WALKING;
            }
            if (Input.GetKey(KeyCode.W) && isOnRope)
            {
                isGrounded = false;
                SP = STATUS_PLAYER.ROPING;
            }
            if(Input.GetKey(KeyCode.S) && isOnRope)
            {
                isGrounded = false;
                SP = STATUS_PLAYER.ROPING;
            }
        }
        if(SP == STATUS_PLAYER.WALKING)
        {
            if (Input.GetKey(KeyCode.A))
            {
                this.gameObject.GetComponent<Transform>().Translate(-this.speed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                this.gameObject.GetComponent<Transform>().Translate(this.speed * Time.deltaTime, 0, 0);
            }
            if(Input.GetKey(KeyCode.W) && isOnRope)
            {
                isGrounded = false;
                SP = STATUS_PLAYER.ROPING;
            }
            if(Input.GetKey(KeyCode.S) && isOnRope)
            {
                isGrounded = false;
                SP = STATUS_PLAYER.ROPING;
            }
            else
            {
                SP = STATUS_PLAYER.STANDING;
            }

        }
        if (SP == STATUS_PLAYER.ROPING)
        {
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            this.gameObject.GetComponent<Collider2D>().isTrigger = true;


            if (isGrounded == true)
            {
                SP = STATUS_PLAYER.STANDING;

            }
            if (Input.GetKey(KeyCode.W))
            {
                if (!isGrounded)
                {
                    this.gameObject.GetComponent<Transform>().Translate(0, this.speed * Time.deltaTime, 0);
                }
            }
            else if (Input.GetKey(KeyCode.S))
            {
                if (!isGrounded)
                {
                    this.gameObject.GetComponent<Transform>().Translate(0, -this.speed * Time.deltaTime, 0);
                }
            }
            
        }
        if(SP == STATUS_PLAYER.STAIRING)
        {

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ROPE"))
        {
            isOnRope = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ROPE"))
        {
            isOnRope = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("GROUND") && !isGrounded)
        {
            isGrounded = true;
            Debug.Log(collision);
        }
    }
=======
﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    
    /// <summary>
    /// The player's movement speed
    /// </summary>
    public float speed;
    public GameObject getItems;
    public GameObject canvasObject;

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

    
>>>>>>> f8cde495459b12ca17ec1f1cb64fbc89c0973770
}
