using UnityEngine;

public class WinLoseHandler : MonoBehaviour
{
    private GameObject zombie;
    public SpawnZombies zombieManager;
    public winScreen win;
    public loseScreen lose;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        zombieManager = Object.FindFirstObjectByType<SpawnZombies>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] zombies = GameObject.FindGameObjectsWithTag("Zombie");

        foreach (GameObject zombie in zombies)
        {
            if (zombie.transform.position.x < -2)
            {
                lose.stopGame();
            }
        }
        if (zombieManager.killCount >= zombieManager.MaxSpawnCount)
        {
            win.stopGame();
        }
    }
}
