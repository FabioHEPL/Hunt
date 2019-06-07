using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{

    private void Awake()
    {
        FindObjectOfType<ScoreManager>().onScoreChangeEvent += ScoreChangeEventListener;
    }

    private void Start()
    {
       
    }

    private void ScoreChangeEventListener(object sender, ScoreManager.OnScoreChangeEventArgs e)
    {
        GetComponent<Text>().text = e.score.ToString();
    }
}
