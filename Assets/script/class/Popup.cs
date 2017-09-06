using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup {
    private string text;
    private GameObject a;
    private int popup_num;
    
    public Popup(string text, GameObject a, int popup_num)
    {
        this.text = text;
        this.a = a;
        this.popup_num = popup_num;
    }

    public string getText()
    {
        return this.text;
    }

    public GameObject geta()
    {
        return this.a;
    }

    public int getpopup_num()
    {
        return this.popup_num;
    }

    public void setText(string text)
    {
        this.text = text;
    }

    public void seta(GameObject a)
    {
        this.a = a;
    }

    public void setpopup_num(int popup_num)
    {
        this.popup_num = popup_num;
    }

}
