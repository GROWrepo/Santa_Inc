using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testNPC : MonoBehaviour, I_NPC {
    public dialog[] dialogs;

    public dialog[] getDialogs(GameObject GO)
    {
        GO.SendMessage("setCurrent", dialogs, SendMessageOptions.DontRequireReceiver);
        return this.dialogs;
    }

    public int getDialogSize()
    {
        return dialogs.Length;
    }

    // Use this for initialization
    void Start () {
        dialogs = new dialog[9];
        dialogs[0] = new dialog("1", 0);
        dialogs[1] = new dialog("2", 1);
        dialogs[2] = new dialog("3", 0);
        dialogs[3] = new dialog("4", 1);
        dialogs[4] = new dialog("5", 0);
        dialogs[5] = new dialog("6", 1);
        dialogs[6] = new dialog("7", 0);
        dialogs[7] = new dialog("8", 1);
        dialogs[8] = new dialog("9", 0);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
