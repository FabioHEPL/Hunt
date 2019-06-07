using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerBack : MonoBehaviour
{
    public GameObject player;

    private void Awake()
    {       
        FindObjectOfType<ColliderManager>().onCollisionEvent += OnCollisionEventHandler;
    }

    private void Start()
    {
        transform.position = DataContainer.singleton.data.playerPosition;
    }

    private void OnCollisionEventHandler(object sender, ColliderManager.onCollisionEventArgs e)
    {
        Debug.Log(e);
        if (e.type.ToString() == "obstacle" || e.type.ToString()  == "bullet")
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
