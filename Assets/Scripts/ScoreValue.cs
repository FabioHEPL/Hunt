using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreValue : MonoBehaviour
{
        float score;
        float scoreMultiplier;
        float scorePerTime;
    // Start is called before the first frame update
    void Start()
    {
        score = DataContainer.singleton.data.score.score;
        scoreMultiplier = DataContainer.singleton.data.score.scoreMultiplier;
        scorePerTime = DataContainer.singleton.data.score.scorePerTime;
    }

    // Update is called once per frame
    void Update()
    {
        score += scorePerTime/60;
        Debug.Log(score.ToString("0.00"));
    }
}
