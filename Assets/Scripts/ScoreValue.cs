using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreValue : MonoBehaviour
{

    public float score = 0f;
    public float scorePerTime = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var multiplier = ScoreMultiplier.scoreMultiplier;
        score += scorePerTime * multiplier ;
        Debug.Log(score);
    }
}
