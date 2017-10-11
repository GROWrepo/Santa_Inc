using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommunicationManager : MonoBehaviour {
    GameObject GM;
	// Use this for initialization
	void Start () {
        GM = this.gameObject.GetComponent<Transform>().parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
}
