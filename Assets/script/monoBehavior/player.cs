using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    public float movePower;
    public float jumpPower = 10.0f;

    Rigidbody2D rigid;

    Vector3 movement;
    bool isJump = false;

     


    // Use this for initialization      
    void Start () {
        rigid = gameObject.GetComponent<Rigidbody2D>();
        movePower = 5.0f;
    }

    // Update is called once per frame
    
    void Update()
    {
        Move();
        Jump();
        if (Input.GetButtonDown("Jump"))
        {
            isJump = true;
        }
    }
    void FixedUpdate()
    {
    }
    void Move ()
    {
        Vector3 moveVelocity = Vector3.zero;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveVelocity = Vector3.right;
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            moveVelocity = Vector3.left;
        }
        transform.position += moveVelocity * movePower * Time.deltaTime;
    }
    void Jump ()
    {
        if (!isJump)
            return;
        rigid.velocity = Vector2.zero;

        Vector2 jumpVelocity = new Vector2(0, jumpPower);
        rigid.AddForce(jumpVelocity, ForceMode2D.Impulse);

        isJump = false;
    }
}
