using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCamera : MonoBehaviour {
    GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        updatePosition();
	}

    void updatePosition()
    {
        this.transform.Translate(new Vector2(player.transform.position.x - this.transform.position.x, player.transform.position.y - this.transform.position.y));
    }
}
