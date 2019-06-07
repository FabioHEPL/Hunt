using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMultiplier : MonoBehaviour
{
    float scoreMultiplier;
    float multiplierForce;
    float timeToMultiply;

    public class ScoreMultiplyEventArgs : EventArgs
    {
       public float multiplier;
    }

    public EventHandler<ScoreMultiplyEventArgs> onScoreMultiply;

    private void OnScoreMultiply(ScoreMultiplyEventArgs e)
    {
        if (onScoreMultiply != null)
            onScoreMultiply(this, e);
    }


    public void Start()
    {
        scoreMultiplier = DataContainer.singleton.data.score.scoreMultiplier;
        multiplierForce = DataContainer.singleton.data.score.multiplierForce;
        timeToMultiply = DataContainer.singleton.data.score.timeToAddMultiplier;
        StartCoroutine("AddMultiplier");
    }

    IEnumerator AddMultiplier()
    {
        yield return new WaitForSeconds(timeToMultiply);
        scoreMultiplier += multiplierForce;
        OnScoreMultiply(new ScoreMultiplyEventArgs() { multiplier = scoreMultiplier });
        StartCoroutine("AddMultiplier");
    }


}

/*
     float scoreMultiplier;
    float timeToAddMultiplier;
    float multiplierForce;

    // Start is called before the first frame update
    void Start()
    {
        scoreMultiplier = DataContainer.singleton.data.score.scoreMultiplier;
        timeToAddMultiplier = DataContainer.singleton.data.score.timeToAddMultiplier;
        multiplierForce = DataContainer.singleton.data.score.multiplierForce;

        StartCoroutine("AddMultiplier");
    }

    // Update is called once per frame
    void Update()
    {

    }

   

    IEnumerator AddMultiplier()
    {
        scoreMultiplier += multiplierForce;
        yield return new WaitForSeconds(timeToAddMultiplier);
        StartCoroutine("AddMultiplier");
    }

    */
