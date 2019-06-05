using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMultiplier : MonoBehaviour
{

    float scoreMultiplier;
    float timeToAddMultiplier;
    float multiplierForce;

    // Start is called before the first frame update
    void Start()
    {
        scoreMultiplier = DataContainer.singleton.DataMaster.score.scoreMultiplier;
        timeToAddMultiplier = DataContainer.singleton.DataMaster.score.timeToAddMultiplier;
        multiplierForce = DataContainer.singleton.DataMaster.score.multiplierForce;

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

}
