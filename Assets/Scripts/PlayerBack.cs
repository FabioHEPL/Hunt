using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerBack : MonoBehaviour
{
    public GameObject player;

    private void Awake()
    {
        transform.position = DataContainer.singleton.data.playerPosition;
        FindObjectOfType<ColliderManager>().onCollisionEvent += OnCollisionEventHandler;
    }

    private void OnCollisionEventHandler(object sender, ColliderManager.onCollisionEventArgs e)
    {
        if (e.type == ColliderManager.colliderType.obstacle)
        { 
            OnPlayerBack(new OnPlayerBackEventAgrs());
        }
    }

    private class OnPlayerBackEventAgrs : EventArgs
    {
        
    }

    private EventHandler<OnPlayerBackEventAgrs> onPlayerBack;

    private void OnPlayerBack(OnPlayerBackEventAgrs e)
    {
        transform.position -= new Vector3(DataContainer.singleton.data.back, 0.0f, 0.0f);
        if (onPlayerBack != null)
            onPlayerBack(this, e);
    }
}
