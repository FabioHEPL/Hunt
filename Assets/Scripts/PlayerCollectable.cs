using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerCollectable : MonoBehaviour
{
    public enum collected
    {
        coin,
        powerUp
    }

    private void Awake()
    {
        FindObjectOfType<ColliderManager>().onCollisionEvent += onCollisionEventHandler;
    }

    private void onCollisionEventHandler(object sender, ColliderManager.onCollisionEventArgs e)
    {
        if (e.type == ColliderManager.colliderType.powerUp)
            OnCollectable(new OnCollectableEventArgs() { collectedObject = collected.powerUp });
        if (e.type == ColliderManager.colliderType.coin)
            OnCollectable(new OnCollectableEventArgs() { collectedObject = collected.coin });
    }

    private class OnCollectableEventArgs : EventArgs
    {
        public collected collectedObject;
    }

    private EventHandler<OnCollectableEventArgs> onCollectable;

    private void OnCollectable(OnCollectableEventArgs e)
    {
        if (onCollectable != null)
            onCollectable(this, e);
    }
}
