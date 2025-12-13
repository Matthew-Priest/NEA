using JetBrains.Annotations;
using System.Threading;
using UnityEngine;

public class SpawnZombies : MonoBehaviour
{
    public GameObject ZombiePrefab;

    public Transform[] spawnPoints;

    public int MaxSpawnCount = 20;
    public int SpawnCount = 0;
    public float spawnInterval = 15f;
    public float timer;

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0 && SpawnCount < MaxSpawnCount) 
        {
            timer = spawnInterval;
            spawnZombie();
        }
    }
    private void spawnZombie()
    {
        int randnum = Random.Range(1, 6);
        Transform selectedrow = spawnPoints[randnum - 1];
        //Debug.Log(randnum);
        Instantiate(ZombiePrefab, selectedrow.position, Quaternion.identity);
        SpawnCount+= 1;
    }
}
