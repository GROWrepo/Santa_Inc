using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour
{
    // Use this for initialization
	void Start () {
        Debug.Log("alive");
	}

	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("GROUND"))
        {
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("GROUND"))
        {
            collision.isTrigger = false;
            this.transform.parent.gameObject.SendMessage("setIsGround", true);
            this.transform.parent.gameObject.SendMessage("setGround", collision.gameObject);

        }
    }
}
