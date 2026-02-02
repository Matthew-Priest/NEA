using JetBrains.Annotations;
using System.Threading;
using UnityEngine;

public class SpawnZombies : MonoBehaviour
{
    public GameObject ZombiePrefab;

    public Transform[] spawnPoints;

    public int MaxSpawnCount = 20;
    public int SpawnCount = 0;
    private float spawnInterval = 12f; //12
    public float timer;
    public int killCount;

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0) 
        {
            timer = spawnInterval;
            spawnZombie();
            
        }
    }
    private void spawnZombie()
    {
        if (SpawnCount < MaxSpawnCount)
        {
            int randnum = Random.Range(1, 6);
            Transform selectedrow = spawnPoints[randnum - 1];
            Instantiate(ZombiePrefab, selectedrow.position, Quaternion.identity);
            SpawnCount += 1;
            Debug.Log(SpawnCount);
        }

    }
    private void Start()
    {
        killCount = 0;
    }
}
