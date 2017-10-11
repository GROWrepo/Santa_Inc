using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface I_NPC {
    int getDialogSize();
    dialog[] getDialogs(GameObject GO);
}
