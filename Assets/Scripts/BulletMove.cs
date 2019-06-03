using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    void _BulletMove()
    {
        transform.Translate(Vector3.right * BulletSpeed* Time.deltaTime);
    }

}





