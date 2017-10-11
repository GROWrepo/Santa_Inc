using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PU_Input : MonoBehaviour {
    public InputField InputText;
    public GameObject buttons;
    public Button apply;
    string answer;

	// Use this for initialization
	void Start () {
        apply = this.gameObject.transform.GetChild(1).gameObject.GetComponent<Button>();
        InputText = this.gameObject.transform.GetChild(2).gameObject.GetComponent<InputField>();
        apply.onClick.AddListener(delegate { i_f(InputText.text); });

    }
	
	
    /*
    // Update is called once per frame
	void Update () {
        Debug.Log(InputText.transform.GetChild(2).gameObject.GetComponent<Text>().text);
	}
    */

    public void i_f(string result)
    {
        this.gameObject.transform.parent.gameObject.SendMessage("sendInput", result);
    }

}
