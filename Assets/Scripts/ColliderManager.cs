using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ColliderManager : MonoBehaviour
{
    public enum colliderType
    {
        powerUp,
        dog,
        obstacle
    }

    public class onCollisionEventArgs : EventArgs
    {
        public ColliderManager.colliderType type;
    }

    public EventHandler<onCollisionEventArgs> onCollisionEvent;

    private void OnCollisionEvent(onCollisionEventArgs args)
    {
        if (onCollisionEvent != null)
            onCollisionEvent(this, args);
    }
}
