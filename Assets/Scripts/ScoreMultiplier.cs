using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMultiplier : MonoBehaviour
{
    public static float scoreMultiplier = 1.0f;
    public float timeToAddMultiplier = 5f;
    public float multiplierForce = 10f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var time = 0f;
        time += Time.deltaTime;
        if (time >= timeToAddMultiplier)
        {
            AddMultiplier();
            time = 0f;
        }
    }

    private void AddMultiplier()
    {
        scoreMultiplier += multiplierForce;
    }
}
