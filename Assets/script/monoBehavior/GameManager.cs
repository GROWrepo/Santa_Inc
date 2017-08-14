using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    STATUS_GAME SG;
    dialog current;
	// Use this for initialization
	void Start () {
        SG = STATUS_GAME.MENU;
        current = null;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnGUI()
    {
        if(this.SG == STATUS_GAME.DIALOGING)
        {
            if (this.current == null)
                this.SG = STATUS_GAME.PAUSE;
            else
            {

            }
        }
    }
    private void setCurrent(dialog dialogs)
    {
        this.current = dialogs;
    }
}
