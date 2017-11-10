using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCamera : MonoBehaviour {
    GameObject player;
    Transform[] landscapes;
    Transform[] ends;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        landscapes = GameObject.Find("LandScapeManager").transform.GetComponentsInChildren<Transform>();
        ends = landscapes[0].GetComponentsInChildren<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        updatePosition();
	}

    void updatePosition()
    {
        if (player.transform.position.x >= (ends[0].position.x + 8.4) && player.transform.position.x <= (ends[1].position.x - 8.4))
        {
            this.transform.Translate(new Vector2(player.transform.position.x - this.transform.position.x, 0));
        }
        if (player.transform.position.y >= (landscapes[1].position.y + 4.5))
        {
            this.transform.Translate(new Vector2(0, player.transform.position.y - this.transform.position.y));
        }
    }
}
