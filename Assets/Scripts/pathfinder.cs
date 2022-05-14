using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathfinder : MonoBehaviour
    
{   
    EnemySpawner enemyspawner;
    waveConfigso waveConfig;
    List<Transform> waypoints;
    int waypointIndex = 0;
    
    
    void Awake()
    {
        enemyspawner = FindObjectOfType<EnemySpawner>();

    }
    
    void Start()
    {   
        waveConfig = enemyspawner.GetCurrentWave();
        waypoints = waveConfig.GetWaypoints();
        transform.position = waypoints[waypointIndex].position;
    }

   
    void Update()
    {
        Followpath();
    }
    void Followpath()
    {
        if(waypointIndex < waypoints.Count)
        {
            Vector3 targetPosition = waypoints[waypointIndex].position;
            float delta = waveConfig.GetMoveSpd() * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, delta);
            if(transform.position == targetPosition)
            {
                waypointIndex++;
            }

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
