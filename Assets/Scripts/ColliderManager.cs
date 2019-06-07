using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ColliderManager : MonoBehaviour
{
    public enum colliderType
    {
        coin,
        powerUp,
        dog,
        obstacle,
        bullet
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
       string colliderTag = collision.gameObject.tag;
        colliderType colliderType;
        
        if (gameObject.tag == "Player")
        {
            switch (colliderTag)
            {
                case ("coin"):
                    colliderType = colliderType.coin;
                    OnCollisionEvent(new onCollisionEventArgs() { type = colliderType });
                    break;

                case ("powerUp"):
                    colliderType = colliderType.powerUp;
                    break;

                case ("dog"):
                    colliderType = colliderType.dog;
                    OnCollisionEvent(new onCollisionEventArgs() { type = colliderType });
                    break;

                case ("obstacle"):
                    colliderType = colliderType.obstacle;
                    OnCollisionEvent(new onCollisionEventArgs() { type = colliderType });
                    break;

                case ("bullet"):
                    colliderType = colliderType.obstacle;
                    OnCollisionEvent(new onCollisionEventArgs() { type = colliderType });
                    break;

                default:
                    break;
            }
        } 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

    }
 
}
