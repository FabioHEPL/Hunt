using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float bulletSpeed;

    private void Move()
    {
        transform.Translate(Vector3.right * bulletSpeed * Time.deltaTime);
    }

}





