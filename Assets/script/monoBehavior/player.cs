using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float movePower = 1f;
    public float jumpPower = 1f;

    Rigidbody2D rigid;

    Vector3 movement;
    bool isJump = false;

    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            isJump = true;
        }
        {
            Vector3 moveVelocity = Vector3.zero;

            if (Input.GetAxisRaw("Horizontal") < 0 )
            {
                moveVelocity = Vector3.left;
            }
            else if (Input.GetAxisRaw("Horizontal") > 0 )
            {
                moveVelocity = Vector3.right;
            }

            transform.position += moveVelocity * movePower * Time.deltaTime;

        }
        {
            if (!isJump)
                return;
            rigid.velocity = Vector2.zero;

            Vector2 jumpVelocity = new Vector2(0, jumpPower);
            rigid.AddForce(jumpVelocity, ForceMode2D.Impulse);

            isJump = false;
        }
    }

    
}

  