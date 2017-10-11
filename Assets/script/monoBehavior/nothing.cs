using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nothing : MonoBehaviour {
    private int push_button;
    public GameObject buttons;
    public Button nothing_bt;

    // Use this for initialization
    void Start()
    {
        nothing_bt = this.gameObject.transform.GetChild(0).gameObject.GetComponent<Button>();
        nothing_bt.onClick.AddListener(delegate { clickNothing(true); });
    }

    // Update is called once per frame
    void Update()
    {

    }

    void clickNothing(bool result)
    {
        this.gameObject.transform.parent.gameObject.SendMessage("sendNothing", result);
    }
}
