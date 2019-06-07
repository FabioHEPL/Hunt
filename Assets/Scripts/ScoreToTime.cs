using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreToTime : MonoBehaviour
{

    float scoreMultiplier;
    float scorePerSecond;

    private void Awake()
    {
        FindObjectOfType<ScoreMultiplier>().onScoreMultiply += OnScoreMultiplyEventListener;
    }

    private void Start()
    {
        StartCoroutine("AddScore");
        scorePerSecond = DataContainer.singleton.data.score.scorePerTime;
    }


    public class ScorePerSecondEventArgs : EventArgs
    {
        public float scoreToAdd;
    }

    public EventHandler<ScorePerSecondEventArgs> onScorePerSecondEvent;

    private void OnScorePerSecondEvent(ScorePerSecondEventArgs e)
    {
        if (onScorePerSecondEvent != null)
            onScorePerSecondEvent(this, e);
    }


    private void OnScoreMultiplyEventListener(object sender, ScoreMultiplier.ScoreMultiplyEventArgs e)
    {
        scoreMultiplier = e.multiplier;
    }


    IEnumerator AddScore()
    {
        float score = scorePerSecond * scoreMultiplier;
        yield return new WaitForSeconds(1);
        OnScorePerSecondEvent(new ScorePerSecondEventArgs() { scoreToAdd = score });
        StartCoroutine("AddScore");
    }

}
