using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    STATUS_GAME SG;
    GameObject canvas;
    public GameObject selectedObject;
    public GameObject doubleClickObject;
    public dialog[] current;
    Ray2D clickRay;
    //RaycastHit2D hit;
    RaycastHit2D[] hits;
    public ContactFilter2D filter;
    float doubleClickCount;
    public float time;

    // Use this for initialization
    void Start () {
        canvas = GameObject.Find("Canvas");
        SG = STATUS_GAME.MENU;
        current = null;
        hits = new RaycastHit2D[10];
        filter = new ContactFilter2D();
        filter.useTriggers = true;
        doubleClickCount = 0;
        time = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        hits[0] = new RaycastHit2D();
        time += Time.deltaTime;
        if(time - doubleClickCount > 0.5f)
        {
            doubleClickObject = null;
        }
        if (Input.GetMouseButtonDown(0))
        {
            clickRay = new Ray2D(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)), Vector2.zero);
            Physics2D.Raycast(clickRay.origin, clickRay.direction, filter, hits);
            /*hit = Physics2D.Raycast(clickRay.origin, clickRay.direction, filter, hits);
            if (hit.collider != null)
            {
                //Debug.Log(hit.transform.gameObject);
                //selectedObject = hits[0].transform.gameObject;
            }*/
            if(hits[0].collider != null)
            {
                if (doubleClickObject == hits[0].transform.gameObject)
                {
                    doubleClicked(doubleClickObject);
                }
                Debug.Log(hits[0].transform.gameObject);
                selectedObject = hits[0].transform.gameObject;
                doubleClickObject = hits[0].transform.gameObject;
                doubleClickCount = this.time;
            }
        }
        if(this.SG == STATUS_GAME.DIALOGING)
        {
            canvas.transform.GetChild(0).gameObject.SetActive(true);
        }
	}
    private void OnGUI()
    {
        
    }
    private void setCurrent(dialog[] dialogs)
    {
        this.current = dialogs;
    }
    public STATUS_GAME getSG()
    {
        return this.SG;
    }
    void doubleClicked(GameObject doubleClickedObject)
    {
        if(doubleClickedObject.tag == "NPC")
        {
            doubleClickedObject.SendMessage("getDialogs", this.gameObject);
            this.SG = STATUS_GAME.DIALOGING;
        }
    }
}
