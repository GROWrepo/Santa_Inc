using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YesNo : MonoBehaviour {
    private int push_button;
    public GameObject buttons;
    public Button Yes, No;

	void Start ()
    {
        Yes = this.gameObject.transform.GetChild(1).gameObject.GetComponent<Button>();
        No = this.gameObject.transform.GetChild(2).gameObject.GetComponent<Button>();
        Yes.onClick.AddListener(delegate { click(true); });
        No.onClick.AddListener(delegate { click(false); });
    }
	
	// Update is called once per frame
	void Update ()
    {

    }
    
    void click(bool result)
    {
        this.gameObject.transform.parent.gameObject.SendMessage("sendYoN", result);
    }
}
