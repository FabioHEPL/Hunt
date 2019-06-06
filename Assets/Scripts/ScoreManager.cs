using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ScoreManager : MonoBehaviour
{
    float currentScore;

    private void Awake()
    {
        FindObjectOfType<ScoreToTime>().onScorePerSecondEvent += ScorePerSecondEventListener;
    }

    public class OnScoreChangeEventArgs : EventArgs
    {
        public float score;
    }

    public EventHandler<OnScoreChangeEventArgs> onScoreChangeEvent;

    private void OnScoreChangeEvent(OnScoreChangeEventArgs e)
    {
        if (onScoreChangeEvent != null)
            onScoreChangeEvent(this, e);
    }

    private void ScorePerSecondEventListener(object sender, ScoreToTime.ScorePerSecondEventArgs e)
    {
        currentScore += e.scoreToAdd;
        OnScoreChangeEvent(new OnScoreChangeEventArgs() { score = currentScore });
    }

}
