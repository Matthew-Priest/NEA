using JetBrains.Annotations;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnZombies : MonoBehaviour
{
    public lvl1Settings lvl1;
    public GameObject ZombiePrefab;
    public placePlant placePlant;
    public Transform[] spawnPoints;
    string sceneName;
    public int MaxSpawnCount;
    public int SpawnCount = 0;
    private float spawnInterval = 12f; 
    public float timer;
    public int killCount;

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0) 
        {
            int randnum = UnityEngine.Random.Range(1, 3);
            timer = spawnInterval;
            if (randnum == 2)
            {
                attackLeastDefendedLane();
            } else
            {
                spawnZombie();
            }            
        }
    }
    private void spawnZombie()
    {
        if (SpawnCount < MaxSpawnCount)
        {
            int randnum = UnityEngine.Random.Range(1, 6);
            Transform selectedrow = spawnPoints[randnum - 1];
            Instantiate(ZombiePrefab, selectedrow.position, Quaternion.identity);
            Debug.Log("placed zombie normally");
            SpawnCount += 1;
            //Debug.Log(SpawnCount);
        }
    }
    private void Start()
    {
        killCount = 0;
        placePlant = UnityEngine.Object.FindFirstObjectByType<placePlant>();
        if (sceneName == "Level one")
        {
            spawnInterval = lvl1.SpawnCooldown;
        }
        else if (sceneName == "Level two")
        {

        }
        else if (sceneName == "Level three")
        {

        }
    }
    private void attackLeastDefendedLane()
    {
        if (SpawnCount < MaxSpawnCount)
        {
            int smallest = 999;
            int index = -1;
            for (int i = 0; i < spawnPoints.Length; i++)
            {
                if (placePlant.rowValue[i] < smallest)
                {
                    smallest = placePlant.rowValue[i];
                    index = i;
                }
            }
            Transform selectedrow = spawnPoints[index];
            Instantiate(ZombiePrefab, selectedrow.position, Quaternion.identity);
            Debug.Log("placed by AI");
            SpawnCount += 1;
        }

    }
    private void Awake()
    {
        lvl1 = UnityEngine.Object.FindFirstObjectByType<lvl1Settings>();
        sceneName = SceneManager.GetActiveScene().name;
        if (sceneName == "Level one")
        {
            MaxSpawnCount = lvl1.SpawnCooldown;
        }
        else if (sceneName == "Level two")
        {

        }
        else if (sceneName == "Level three")
        {

        }

    }
}
