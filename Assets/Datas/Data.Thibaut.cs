using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// CreateAssetMenu qui permet de créer cet objet depuis le menu dans l'inspector
//[CreateAssetMenu(fileName = "Data", menuName = "Data/Thibaut", order = 0)]

// La classe doit descendre de scriptableObject qui est une classe de Unity
public partial class Data : ScriptableObject
{
    [System.Serializable]
    public class Score
    {
        public float scoreMultiplier;
        public float timeToAddMultiplier;
        public float multiplierForce;
        public float score;
        public float scorePerTime;
        public float coinScore;
    }

    public float backgroundSpeed;
    public float itemSpeed;
    public float timeToGameOver;

    public Score score;

}