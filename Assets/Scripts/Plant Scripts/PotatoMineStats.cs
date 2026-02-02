using UnityEngine;

public class PotatoMineStats : ClassicPlantStats
{
    public GameObject enemy;
    public float explosionRadius = 2f;
    public LayerMask enemyLayer;
    private void explode()
    {
        /*Vector3 position = gameObject.transform.position;
        float ExplosionMinX = position.x - 1;
        float ExplosionMaxX = position.x + 1;
        float ExplosionMinY = position.y - 1;
        float ExplosionMaxY = position.y + 1;
        if(enemy.transform.position.x >=  ExplosionMinX && enemy.transform.position.x  <= ExplosionMaxX && enemy.transform.position.y >= ExplosionMinY && enemy.transform.position.y <= ExplosionMaxY)
        {
            Destroy(gameObject);
        }*/
        Collider2D[] enemies = Physics2D.OverlapCircleAll(transform.position, explosionRadius, enemyLayer);
        foreach (Collider2D enemy in enemies)
        {
            Destroy(enemy.gameObject);
        }
        Destroy(gameObject);
        Vector3 coords = transform.position;
        removePlant.vectorGameObjectPairs.Remove(coords);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Zombie"))
        {
            explode();
        }
    }
    private void Start()
    {
        removePlant = Object.FindFirstObjectByType<placePlant>();
    }

}
