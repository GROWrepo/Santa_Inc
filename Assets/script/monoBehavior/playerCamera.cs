using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCamera : MonoBehaviour {
    GameObject player;
    Transform[] ends;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        ends = GameObject.Find("LandScapeManager").transform.GetComponentsInChildren<Transform>();
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
