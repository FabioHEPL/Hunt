using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreValue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var scoreMultiplier = DataContainer.singleton.Data.scoreMultiplier;
        var score = DataContainer.singleton.Data.score;
        var scorePerTime = DataContainer.singleton.Data.scorePerTime;

        score += scorePerTime * scoreMultiplier;
        Debug.Log(score);
    }
}
