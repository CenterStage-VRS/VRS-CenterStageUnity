using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamKeyButton : KeyBoundButton
{
    public TeamColor buttonTeam;

    public override bool checkCanPress()
    {
        if(buttonTeam == PowerPlayFieldManager.botColor)
        {
            return true;
        }
        else { return false; }
    }
}
