using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrow : MonoBehaviour
{
    bool fury;
    bool canFury;

    private void Start()
    {
        GetComponent.
        GetComponent<ColliderManager>().onCollisionEvent += OnCollisionEvent;
    }

    private void OnCollisionEvent(object o, ColliderManager.onCollisionEventArgs args)
    {
        if (args.type == ColliderManager.colliderType.obstacle && )
        {
             
        }
    }

    private void onPresseRageButton(object o, )
    {
        if (canFury)
        {
            Fury();
        }
    }

    private void Fury()
    {
        fury = true;

    }
}
