using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerBack : MonoBehaviour
{
    private class OnPlayerBackEventAgrs : EventArgs
    {

    }

    private EventHandler<OnPlayerBackEventAgrs> onPlayerBack;

    private void OnPlayerBack(OnPlayerBackEventAgrs e)
    {
        if (onPlayerBack != null)
            onPlayerBack(this, e);
    }
}
