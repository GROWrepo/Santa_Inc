using System.Collections;
using System.Collections.Generic;

public class dialog{
    private string dialogs;
    private int owner; // 0 : player, 1 ~ : NPC

    public dialog(string dialogs)
    {
        this.dialogs = dialogs;
        this.owner = 0;
    }
    public dialog(string dialogs, int owner)
    {
        this.dialogs = dialogs;
        this.owner = owner;
    }

    #region getter
    public string getDialogs()
    {
        return this.dialogs;
    }
    public int getOwner()
    {
        return this.owner;
    }
    #endregion
    #region setter
    public void setDialogs(string dialogs)
    {
        this.dialogs = dialogs;
    }
    public void setOwner(int owner)
    {
        this.owner = owner;
    }
    #endregion
}
