using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : Spawn
{

    void Start()
    {
        minTimeToSpawn = DataContainer.singleton.data.spawn.minTimeToSpawnObstacle;
        maxTimeToSpawn = DataContainer.singleton.data.spawn.maxTimeToSpawnObstacle;
        StartCoroutine("Spawner");
    }

    public override IEnumerator Spawner ()
    {
        float timeToSpawn = Random.Range(minTimeToSpawn, maxTimeToSpawn);
        int obstacleToSpawn = Random.Range(0, DataContainer.singleton.data.spawn.obstaclesPrefabs.Count);
        spawn = DataContainer.singleton.data.spawn.obstaclesPrefabs[obstacleToSpawn];
        yield return new WaitForSeconds(timeToSpawn);
        Instantiate(spawn, transform.position, transform.rotation);
        StartCoroutine("Spawner");
    }
    
}
