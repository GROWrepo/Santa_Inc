using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ok : MonoBehaviour {
    private int push_button;
    public GameObject buttons;
    public Button ok;

	// Use this for initialization
	void Start () {
        ok = this.gameObject.transform.GetChild(1).gameObject.GetComponent<Button>();
        ok.onClick.AddListener(delegate { clickOk(true); });
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void clickOk(bool result)
    {
        this.gameObject.transform.parent.gameObject.SendMessage("sendOk", result);
    }
}
