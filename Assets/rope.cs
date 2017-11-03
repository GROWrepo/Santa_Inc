using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rope : MonoBehaviour
{
    Rigidbody2D rigid;
    Vector3 movement;
    public bool isGrounded;
    public bool isOnRope;
    GameObject player;

    // Use this for initialization
    void Start ()
    {
        player = GameObject.FindWithTag("Player");
        isGrounded = false;
        isOnRope = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        {
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.SendMessage("setRope", this.gameObject, SendMessageOptions.DontRequireReceiver);
            Debug.Log(collision);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.SendMessage("setRopeNull");
            Debug.Log(collision);
        }
    }
}
