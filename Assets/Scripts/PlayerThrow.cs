using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrow : MonoBehaviour
{
    bool fury = false;
    bool canFury = false;

    private void Start()
    {
        GetComponent<PlayerGrow>().onPlayerGrowEvent += onPlayerGrowEventHolder;
        FindObjectOfType<InputManager>().ThrowButtonPressed += onPresseRageButton;
        GetComponent<ColliderManager>().onCollisionEvent += OnCollisionEvent;
    }

    private void OnCollisionEvent(object o, ColliderManager.onCollisionEventArgs args)
    {
        if (args.type == ColliderManager.colliderType.obstacle && fury)
        {
            Throw();
        }
    }

    private void onPresseRageButton(object o, ThrowButtonPressedArgs args)
    {
        if (canFury)
        {
            Fury();
        }
    }

    private void Fury()
    {
        fury = true;
        Invoke("StopFury", DataContainer.singleton.data.timeFury);
    }

    private void StopFury()
    {
        fury = false;
    }

    private void Throw()
    {

    }

    private void onPlayerGrowEventHolder(object o, PlayerGrow.onPlayerGrowEnventArgs args)
    {
        if (args.numberOfGrow >= DataContainer.singleton.data.nomberOfGrow)
        {
            canFury = true;
        }
        else
            canFury = false;
    }
}
