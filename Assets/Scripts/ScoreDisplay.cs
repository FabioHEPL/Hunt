using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreText;
    float score;

    // Start is called before the first frame update
    void Start()
    {
        score = DataContainer.singleton.DataMaster.score.score;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = score.ToString("0.00"); ;
    }
}
