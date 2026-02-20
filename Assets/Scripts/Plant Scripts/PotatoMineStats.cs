using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PotatoMineStats : ClassicPlantStats
{
    public GameObject enemy;
    public float explosionRadius = 1f;
    public LayerMask enemyLayer;
    public SpawnZombies killcount;
    public ActivateMine mineactive;

    
    private void explode()
    {
        Collider2D[] enemies = Physics2D.OverlapCircleAll(transform.position, explosionRadius, enemyLayer);
        foreach (Collider2D enemy in enemies)
        {
            if(enemy.tag == "Zombie" && mineactive.isArmed)
            {
                Destroy(enemy.gameObject);
                killcount.killCount += 1;
                Destroy(gameObject);
                Vector3 coords = transform.position;
                removePlant.vectorGameObjectPairs.Remove(coords);
            }
        }

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Zombie"))
        {
            explode();
        }
    }
    private void Start()
    {
        //removePlant = Object.FindFirstObjectByType<placePlant>();
        if (sceneName == "Level one")
        {
            maxHealth = lvl1.potatohealth;
            Debug.Log(maxHealth);
        }
        else if (sceneName == "Level two")
        {
            maxHealth = lvl2.potatohealth;
        }
        else if (sceneName == "Level three")
        {
            maxHealth = lvl3.potatohealth;
        }
        
        currentHealth = maxHealth;
        mineactive = Object.FindFirstObjectByType<ActivateMine>();
        killcount = Object.FindFirstObjectByType<SpawnZombies>();
    }
}
