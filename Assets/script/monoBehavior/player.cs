using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    float speed;
    bool isUp;
    bool isRight;

    Rigidbody2D rigid;
    Vector3 movement;

	// Use this for initialization
	void Start ()
    {
        isRight = false;
        isUp = false;

        speed = 5.0f;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKey(KeyCode.A))
        {
            this.gameObject.GetComponent<Transform>().Translate(-this.speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.D))
        {
            this.gameObject.GetComponent<Transform>().Translate(this.speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.W))
        {
            if(this.isUp)
            {
                isUp = true;
                
           }
        }

	}
}
