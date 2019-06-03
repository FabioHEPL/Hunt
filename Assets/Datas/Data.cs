using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CreateAssetMenu qui permet de créer cet objet depuis le menu dans l'inspector
[CreateAssetMenu(fileName = "Data", menuName = "Data/Thibaut", order = 0)]

// La classe doit descendre de scriptableObject qui est une classe de Unity
public class Data : ScriptableObject
{
    [System.Serializable]
    public class Thibaut
    {

    }
}