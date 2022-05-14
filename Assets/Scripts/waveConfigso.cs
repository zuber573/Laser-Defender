using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Wave Config", fileName = "New Wave Config")]
public class waveConfigso : ScriptableObject
{
    [SerializeField] List<GameObject> enemyPrefabs;
    [SerializeField] Transform pathPrefab;
    [SerializeField] float moveSpd = 5f;
    [SerializeField] float timeBewtweenEnemySpawns = 1f;
    [SerializeField] float spawnTimevariance = 0f;
    [SerializeField] float minimumSpawnTime = 0.2f;
    
    public int GetEnemyCount()
    {
        return enemyPrefabs.Count;
    }

    public GameObject GetEnemyPrefab(int index)
    {
        return enemyPrefabs[index];
    }

    public Transform GetStartingWaypoint()
    {
        return pathPrefab.GetChild(0);
    }

    public List<Transform> GetWaypoints()
    {
        List<Transform> waypoints = new List<Transform>();
        foreach(Transform child in pathPrefab)
        {
            waypoints.Add(child);
        }
        return waypoints;
    }
    
    public float GetMoveSpd()
    {
        return moveSpd;
    }

    public float GetRandomSpawnTime()
    {
        float spawnTime = Random.Range(timeBewtweenEnemySpawns - spawnTimevariance,
                                        timeBewtweenEnemySpawns + spawnTimevariance);
        return Mathf.Clamp(spawnTime, minimumSpawnTime, float.MaxValue);

    }

}