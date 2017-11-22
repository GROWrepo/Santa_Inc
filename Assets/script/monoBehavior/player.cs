using System.Collections;
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
    public GameObject rope;
    public GameObject ground;

	// Use this for initialization
	void Start ()
    {
        isGrounded = false;

        rope = null;

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
                this.gameObject.GetComponent<Animator>().SetInteger("state", 1);
            }
            if (Input.GetKey(KeyCode.D))
            {
                SP = STATUS_PLAYER.WALKING;
                this.gameObject.GetComponent<Animator>().SetInteger("state", 2);
            }
            if (Input.GetKeyDown(KeyCode.W) && isOnRope)
            {
                isGrounded = false;
                ground.GetComponent<Collider2D>().isTrigger = true;
                SP = STATUS_PLAYER.ROPING;
                this.gameObject.GetComponent<Animator>().SetInteger("state", 3);
            }
            if(Input.GetKeyDown(KeyCode.S) && isOnRope)
            {
                isGrounded = false;
                ground.GetComponent<Collider2D>().isTrigger = true;
                SP = STATUS_PLAYER.ROPING;
                this.gameObject.GetComponent<Animator>().SetInteger("state", 3);
            }
        }
        if(SP == STATUS_PLAYER.WALKING)
        {
            if (Input.GetKey(KeyCode.A))
            {
                this.gameObject.GetComponent<Transform>().Translate(-this.speed * Time.deltaTime, 0, 0);
                this.gameObject.GetComponent<Animator>().SetInteger("state", 1);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                this.gameObject.GetComponent<Transform>().Translate(this.speed * Time.deltaTime, 0, 0);
                this.gameObject.GetComponent<Animator>().SetInteger("state", 2);
            }
            else if (Input.GetKey(KeyCode.W) && isOnRope)
            {
                isGrounded = false;
                ground.GetComponent<Collider2D>().isTrigger = true;
                SP = STATUS_PLAYER.ROPING;
                this.gameObject.GetComponent<Animator>().SetInteger("state", 3);
            }
            else if (Input.GetKey(KeyCode.S) && isOnRope)
            {
                isGrounded = false;
                ground.GetComponent<Collider2D>().isTrigger = true;
                SP = STATUS_PLAYER.ROPING;
                this.gameObject.GetComponent<Animator>().SetInteger("state", 3);
            }
            else
            {
                SP = STATUS_PLAYER.STANDING;
                this.gameObject.GetComponent<Animator>().SetInteger("state", 0);
            }

        }
        if (SP == STATUS_PLAYER.ROPING)
        {
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;


            if (isGrounded == true)
            {
                ground.GetComponent<Collider2D>().isTrigger = false;
                SP = STATUS_PLAYER.STANDING;
                this.gameObject.GetComponent<Animator>().SetInteger("state", 0);

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

    void setRopeNull()
    {
        this.rope = null;
        isOnRope = false;
    }

    void setRope(GameObject rope)
    {
        if (rope != null)
        {
            this.rope = rope;
            isOnRope = true;
        }
    }

    void setIsGround(bool isGround)
    {
        this.isGrounded = isGround;
    }
    void setGround(GameObject ground)
    {
        this.ground = ground;
    }
}
