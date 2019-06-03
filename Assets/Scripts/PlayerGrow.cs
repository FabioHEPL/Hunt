using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrow : MonoBehaviour
{
    int numberOfGrow = 0;

    void Grow()
    {
        numberOfGrow++;
        transform.localScale *= 1.2f;
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
