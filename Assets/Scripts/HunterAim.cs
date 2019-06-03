using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunterAim : MonoBehaviour
{
    GameObject Player;


    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {

    }
    private float AxeOfFire()
    {
        Vector2 PlayerPosition = Player.transform.position;
        Vector2 EnemyPosition = transform.position;
        Vector2 bulletRide = PlayerPosition - EnemyPosition;

        bulletRide.Normalize();
        float EnnemyRotation = Mathf.Atan2(bulletRide.y, bulletRide.x) * Mathf.Rad2Deg - 90.0f;

        return EnnemyRotation;
    }
}
