using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    private float bulletSpeed;
    private void Update()
    {
        transform.Translate(Vector3.right * bulletSpeed * Time.deltaTime);
    }
    private void Start()
    {
        bulletSpeed = DataContainer.singleton.data.hunter.BulletSpeed;

    }


}





