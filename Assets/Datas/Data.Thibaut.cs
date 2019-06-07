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
        public float scoreMultiplier = 1;
        public float timeToAddMultiplier = 5;
        public float multiplierForce = 0.2f;
        public float score = 0;
        public float scorePerTime = 5;
        public float coinScore = 100;
    }
    [System.Serializable]
    public class Spawn
    {
        public float minTimeToSpawnCoin;
        public float maxTimeToSpawnCoin;
        public float minTimeToSpawnObstacle;
        public float maxTimeToSpawnObstacle;
        public GameObject coin;
        public List<GameObject> obstaclesPrefabs;
    }


    public Spawn spawn;
    public Score score;

    public float backgroundSpeed = 1f;
    public float itemSpeed = 1.15f;
    public float timeToGameOver;




}