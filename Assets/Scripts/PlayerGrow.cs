using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PlayerGrow : MonoBehaviour
{
    int numberOfGrow = 0;
    public class onPlayerGrowEnventArgs : EventArgs
    {
        public int numberOfGrow;
    }
    public EventHandler<onPlayerGrowEnventArgs> onPlayerGrowEvent;
    private void OnPlayerGrowEvent(onPlayerGrowEnventArgs args)
    {
        if (onPlayerGrowEvent != null)
        {
            onPlayerGrowEvent(this, args);
        }
    }

    void Grow()
    {
        numberOfGrow++;
        transform.localScale *= DataContainer.singleton.data.grow;
        OnPlayerGrowEvent(new onPlayerGrowEnventArgs { numberOfGrow = numberOfGrow });
    }
    private void Start()
    {
        GetComponent<ColliderManager>().onCollisionEvent += OnCollisionEvent;
    }

    private void OnCollisionEvent(object o, ColliderManager.onCollisionEventArgs args)
    {
        if (args.type == ColliderManager.colliderType.powerUp)
        {
            Grow();
        }
    }
}
