using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject coin;

    public event Action<string> Collided;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Collided?.Invoke(collision.gameObject.tag);

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}
