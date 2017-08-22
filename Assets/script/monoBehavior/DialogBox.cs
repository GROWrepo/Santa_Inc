using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
		for(int i = 0; i < this.gameObject.transform.childCount;i++)
        {
            this.gameObject.transform.GetChild(i).gameObject.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
