using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    STATUS_GAME SG;
    public GameObject selectedObject;
    dialog current;
    Ray2D clickRay;
    RaycastHit2D hit;

    // Use this for initialization
    void Start () {
        SG = STATUS_GAME.MENU;
        current = null;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            clickRay = new Ray2D(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)), Vector2.zero);
            hit = Physics2D.Raycast(clickRay.origin, clickRay.direction);
            if(hit.collider != null)
            {
                Debug.Log(hit.transform.gameObject);
            }
        }
	}
    private void OnGUI()
    {
        
    }
    private void setCurrent(dialog dialogs)
    {
        this.current = dialogs;
    }
    public STATUS_GAME getSG()
    {
        return this.SG;
    }
    void getHitObject(RaycastHit hit)
    {
        //this.hit = hit;
    }
}
