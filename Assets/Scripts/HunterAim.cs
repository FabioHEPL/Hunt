using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HunterAim : MonoBehaviour
{
    public GameObject Player;
    float randomAngle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        axeDeTire();
    }
    private void axeDeTire()
    {       
        Vector2 PlayerPosition = Player.transform.position;
        Vector2 EnemyPosition = transform.position;
        Vector2 BulletRide = PlayerPosition - EnemyPosition;

        BulletRide.Normalize();
        float EnemyRotaion = Mathf.Atan2(BulletRide.y, BulletRide.x) * Mathf.Rad2Deg  ;

        transform.rotation = Quaternion.Euler(0, 0, EnemyRotaion);
    }

}
