using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    float coinScore;

    private void Awake()
    {
        FindObjectOfType<ColliderManager>().onCollisionEvent += OnCollisionEventListener;
    }

    private void Start()
    {
        coinScore = DataContainer.singleton.data.score.coinScore;
    }



    public class OnCoinCollectEventArgs : EventArgs
    {
        public float score;
    }

    public EventHandler<OnCoinCollectEventArgs> onCoinCollectEvent;

    private void OnCoinCollectEvent(OnCoinCollectEventArgs e)
    {
        if (onCoinCollectEvent != null)
            onCoinCollectEvent(this, e);
    }

    private void OnCollisionEventListener(object sender, ColliderManager.onCollisionEventArgs e)
    {
        if (e.type.ToString() == "coin")
        {
            OnCoinCollectEvent(new OnCoinCollectEventArgs() { score = coinScore });
            Destroy(e.collided);
        }
    }
}