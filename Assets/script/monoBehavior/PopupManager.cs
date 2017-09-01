using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupManager : MonoBehaviour {
    private GameObject owner;
    public GameObject[] popups;
    GameObject temp;


    void Start () {
        popups = Resources.LoadAll<GameObject>("Pref/Popup");
        this.Create_Popup(new Popup("방가방가", this.gameObject, 2));
	}
	
	// Update is called once per frame
	void Update () {
	}

    void Create_Popup(Popup popup)
    {
        temp = Instantiate(popups[popup.getpopup_num()], this.gameObject.transform);
        this.owner = popup.geta();
        temp.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = popup.getText();
    }

    void Delete_Popup()
    {
        Destroy(temp.gameObject);
    }

    void sendYoN(bool result)
    {
        Debug.Log(result);
        owner.SendMessage("function", result, SendMessageOptions.DontRequireReceiver);
        Delete_Popup();
    }

    void sendOk(bool result)
    {
        Debug.Log(result);
        owner.SendMessage("function", result, SendMessageOptions.DontRequireReceiver);
        Delete_Popup();
    }

    void sendNothing(bool result)
    {
        Debug.Log(result);
        owner.SendMessage("function", result, SendMessageOptions.DontRequireReceiver);
        Delete_Popup();
    }

    void sendInput(string result)
    {
        Debug.Log(result);
        owner.SendMessage("function", result, SendMessageOptions.DontRequireReceiver);
    }
}
