using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public player self = new player();

    float speed;
    bool isRight;
    bool isUp;

    Rigidbody2D rigid;

    Vector3 movement;
    
    
    void Start()
    {
        isRight = false;
        isUp = false;
        speed = 5.0f;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (this.isRight)
            {
                isRight = false;
                this.gameObject.GetComponent<Transform>().GetChild(1).GetComponent<Transform>().Rotate(0, 10, 0);
            }
            this.gameObject.GetComponent<Transform>().Translate(-this.speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (!this.isRight)
            {
                isRight = true;
                this.gameObject.GetComponent<Transform>().GetChild(1).GetComponent<Transform>().Rotate(0, 10, 0);
            }
            this.gameObject.GetComponent<Transform>().Translate(this.speed * Time.deltaTime, 0, 0);
          
        }
        else if (Input.GetKey(KeyCode.W))
        {
            if (!this.isUp)
            {
                isUp = true;
                this.gameObject.GetComponent<Transform>().GetChild(1).GetComponent<Transform>().Rotate(0, 10, 0);
            }
            this.gameObject.GetComponent<Transform>().Translate(0,this.speed * Time.deltaTime, 0);

        }

    }
}

  