using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : Spawn
{

    void Start()
    {
        minTimeToSpawn = DataContainer.singleton.data.spawn.minTimeToSpawnCoin;
        maxTimeToSpawn = DataContainer.singleton.data.spawn.maxTimeToSpawnCoin;
        spawn = DataContainer.singleton.data.spawn.coin;
        StartCoroutine("Spawner");
    }

}
