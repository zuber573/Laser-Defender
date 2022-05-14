using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{   [SerializeField] List<waveConfigso> waveConfigs;
    [SerializeField] float timeBetweenWaves = 0f;
    waveConfigso currentWave;
    void Start()
    {
       StartCoroutine(SpawnEnemies());
    }

    public waveConfigso GetCurrentWave()
    {
        return currentWave;
    }

    IEnumerator SpawnEnemies()
    {   foreach (waveConfigso wave in waveConfigs)
        {
            currentWave = wave;
        for(int i = 0; i < currentWave.GetEnemyCount(); i++)
        {
            Instantiate(currentWave.GetEnemyPrefab(i),
                    currentWave.GetStartingWaypoint().position,
                    Quaternion.identity,
                    transform);
            yield return new WaitForSeconds(currentWave.GetRandomSpawnTime());
        }
            yield return new WaitForSeconds(timeBetweenWaves);
        }           
    }   
   
}
