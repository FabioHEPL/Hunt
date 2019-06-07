using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CreateAssetMenu qui permet de créer cet objet depuis le menu dans l'inspector
[CreateAssetMenu(fileName = "Data", menuName = "Data/Master", order = 0)]

// La classe doit descendre de scriptableObject qui est une classe de Unity
public partial class Data : ScriptableObject
{

}