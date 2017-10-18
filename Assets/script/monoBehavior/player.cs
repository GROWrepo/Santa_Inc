using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    float speed;
    bool isUp;
    bool isRight;

    Rigidbody2D rigid;
    Vector3 movement;
    STATUS_PLAYER SP;

	// Use this for initialization
	void Start ()
    {
        isRight = false;
        isUp = false;

        speed = 5.0f;
        SP = STATUS_PLAYER.STANDING;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (SP == STATUS_PLAYER.STANDING)
        {
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
            if (Input.GetKey(KeyCode.A))
            {
                SP = STATUS_PLAYER.WALKING;
            }
            if (Input.GetKey(KeyCode.D))
            {
                SP = STATUS_PLAYER.WALKING;
            }
            if (Input.GetKey(KeyCode.W))
            {
                SP = STATUS_PLAYER.ROPING;
            }
            if(Input.GetKey(KeyCode.S))
            {
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
            if(Input.GetKey(KeyCode.W))
            {
                SP = STATUS_PLAYER.ROPING;
            }
            if(Input.GetKey(KeyCode.S))
            {
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

            
            if (Input.GetKey(KeyCode.W))
            {
                  this.gameObject.GetComponent<Transform>().Translate(0, this.speed * Time.deltaTime, 0);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                  this.gameObject.GetComponent<Transform>().Translate(0, -this.speed * Time.deltaTime, 0);
            }
            else if 
            {
                 
            }
            
        }
        if(SP == STATUS_PLAYER.STAIRING)
        {

        }
        
            
    }
        
}
