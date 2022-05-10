using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{   
    [SerializedFeild] waveConfigso currentWave;
    void Start()
    {
        spawnEnemies()
    }

    public waveConfigso GetCurrentWave()
    {
        return currentWave;
    }

    void SpawnEnemies()
    {
        Instantiate(currentWave.GetEnemyPrefab(0),
                    currentWave.GetStartingWaypoint().position,
                    Quaternion.identity);
    }
   
}
