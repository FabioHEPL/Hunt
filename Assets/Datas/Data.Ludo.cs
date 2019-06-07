using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// La classe doit descendre de scriptableObject qui est une classe de Unity
public partial class Data : ScriptableObject
{
    [System.Serializable]
    public class Hunter
    {
        public GameObject bullet;
        public float BulletSpeed = 7;
        public float cooldown;
        public float maximumAngle = 10.0f;
        public float minimunAngle = -10.0f;     
    }
    public Hunter hunter;

}