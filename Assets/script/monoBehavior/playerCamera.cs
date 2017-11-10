using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCamera : MonoBehaviour {
    public GameObject player;
    Transform[] landscapes;
    Transform leftEnd;
    Transform rightEnd;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        landscapes = GameObject.Find("LandScapeManager").transform.GetComponentsInChildren<Transform>();
        leftEnd = landscapes[1].GetChild(0);
        rightEnd = landscapes[1].GetChild(1);
    }
	
	// Update is called once per frame
	void Update () {
        if (player.transform.position.x >= (leftEnd.position.x + 8.4) && player.transform.position.x <= (rightEnd.position.x - 8.4))
        {
            Debug.Log("update");
            this.transform.Translate(new Vector3(player.transform.position.x - this.transform.position.x, 0, 0));
        }
        if (player.transform.position.y >= (landscapes[2].position.y + 4.5))
        {
            Debug.Log("update");
            this.transform.Translate(new Vector3(0, player.transform.position.y - this.transform.position.y), 0);
        }
	}

    void updatePosition()
    {
        if (player.transform.position.x >= (leftEnd.position.x + 8.4) && player.transform.position.x <= (rightEnd.position.x - 8.4))
        {
            Debug.Log(player.transform.position.x);
            this.transform.Translate(new Vector3(player.transform.position.x - this.transform.position.x, 0, 0));
        }
        if (player.transform.position.y >= (landscapes[2].position.y + 4.5))
        {
            Debug.Log("update");
            this.transform.Translate(new Vector3(0, player.transform.position.y - this.transform.position.y), 0);
        }
    }
}