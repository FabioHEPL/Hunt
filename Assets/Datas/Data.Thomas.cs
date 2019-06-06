using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CreateAssetMenu qui permet de créer cet objet depuis le menu dans l'inspector
//[CreateAssetMenu(fileName = "Data", menuName = "Data/Thomas", order = 0)]

// La classe doit descendre de scriptableObject qui est une classe de Unity
public partial class Data : ScriptableObject
{
    public float timeFury;

    public int nomberOfGrow;
    public float grow = 1.2f;

    public float back = 1.0f;
    public Vector2 playerPosition = new Vector2(-1.0f, -3.0f);
}