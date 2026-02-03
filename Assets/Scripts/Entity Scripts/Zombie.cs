using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Zombie : Entity
{
    private bool inCollision = false;
    public float attackCooldown = 3;
    public float timer = 3;
    public ClassicPlantStats plantStats;
    private float maxHealth = 80f;
    private float currentHealth;
    public SpawnZombies killCount;

    void Update()
    {
       if(inCollision == false)
        {           
            transform.Translate(Vector2.left * Speed * Time.deltaTime);
        }
        if (inCollision)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                plantStats.takeDamage(10);
                timer = attackCooldown;
            }           
        }
        if(currentHealth <= 0)
        {
            Destroy(gameObject);
            killCount.killCount += 1;
        }
    }
    private void Awake()
    {
        Speed = 0.3f;
        inCollision = false;
        currentHealth = maxHealth;
        
}
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plant"))
        {
            plantStats = collision.gameObject.GetComponent<ClassicPlantStats>();
            Debug.Log("collision detected");
            inCollision = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plant"))
        {
            inCollision = false;
            plantStats = null;
        }
    }
    public void takeDamage()
    {
        currentHealth -= 10;
        Debug.Log($"{gameObject.name} took 10 damage");
    }
    private void Start()
    {
        killCount = Object.FindFirstObjectByType<SpawnZombies>();
    }
}
