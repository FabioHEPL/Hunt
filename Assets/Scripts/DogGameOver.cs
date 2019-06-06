using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DogGameOver : MonoBehaviour
{
    float timeToGameOver;

    private void Start()
    {
        timeToGameOver = DataContainer.singleton.data.timeToGameOver;
    }
    private void Awake()
    {
        FindObjectOfType<ColliderManager>().onCollisionEvent += OnCollisionEventListener;
    }

    private void OnCollisionEventListener(object sender, ColliderManager.onCollisionEventArgs e)
    {
        if (e.type.ToString() == "dog")
            Invoke("GameOver", timeToGameOver);
    }

    private void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}