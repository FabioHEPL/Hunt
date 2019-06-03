using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMultiplier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var timeToAddMultiplier = DataContainer.singleton.Data.timeToAddMultiplier;

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
        var scoreMultiplier = DataContainer.singleton.Data.scoreMultiplier;
        var multiplierForce = DataContainer.singleton.Data.multiplierForce;

        scoreMultiplier += multiplierForce;
    }
}
