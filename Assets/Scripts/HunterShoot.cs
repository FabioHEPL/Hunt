using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunterShoot : MonoBehaviour
{
     GameObject Bullet;
    private float _lastFire;
    private float cooldown;
    float randomAngle;
    float maximumAngle;
    float minimunAngle;
    // Start is called before the first frame update

    void Start()
    {
        cooldown = DataContainer.singleton.data.hunter.cooldown;
        Bullet = DataContainer.singleton.data.hunter.bullet;
        maximumAngle = DataContainer.singleton.data.hunter.maximumAngle;
        minimunAngle = DataContainer.singleton.data.hunter.minimunAngle;
    }

    // Update is called once per frame
    void Update()
    {
        fire();
    }

    void fire()
    {
        if (Time.time >= _lastFire + cooldown)

        {
            //var angleOfShot = transform.rotation + randomAngle;
            Instantiate(Bullet, transform.position, transform.rotation * Quaternion.Euler(0.0f, 0.0f,UnityEngine.Random.Range(minimunAngle, maximumAngle)));
           _lastFire = Time.time;
        }

    }
}
