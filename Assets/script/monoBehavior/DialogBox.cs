using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    void printDialog(dialog current)
    {
        for (int i = 0; i < this.gameObject.transform.childCount; i++)
        {
            if (i != current.getOwner())
            {
                this.gameObject.transform.GetChild(i).gameObject.SetActive(false);
                this.gameObject.transform.GetChild(i).GetChild(0).gameObject.GetComponent<Text>().text = current.getDialogs();
            }
            else
            {
                this.gameObject.transform.GetChild(i).gameObject.SetActive(true);
                this.gameObject.transform.GetChild(i).GetChild(0).gameObject.GetComponent<Text>().text = current.getDialogs();
            }
        }
    }
    void closeDialog()
    {
        for (int i = 0; i < this.gameObject.transform.childCount; i++)
        {
            this.gameObject.transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}
