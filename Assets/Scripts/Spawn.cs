using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawn : MonoBehaviour
{
    public float minTimeToSpawn;
    public float maxTimeToSpawn;
    public GameObject spawn;

    public virtual IEnumerator Spawner ()
    {
        float timeToSpawn = Random.Range(minTimeToSpawn, maxTimeToSpawn);
        Instantiate(spawn, transform.position, transform.rotation);
        yield return new WaitForSeconds(timeToSpawn);
        StartCoroutine("Spawner");
    }

}
 
