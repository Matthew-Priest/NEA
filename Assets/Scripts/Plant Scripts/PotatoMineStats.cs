using Unity.VisualScripting;
using UnityEngine;

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
        killcount = Object.FindFirstObjectByType<SpawnZombies>();
        removePlant = Object.FindFirstObjectByType<placePlant>();
        mineactive = Object.FindFirstObjectByType<ActivateMine>();
        maxHealth = 30;
        currentHealth = maxHealth;

    }
}
