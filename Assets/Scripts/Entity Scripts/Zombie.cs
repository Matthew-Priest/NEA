using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Zombie : Entity
{
    private bool inCollision = false;
    public float attackCooldown = 3;
    public float timer = 3;
    private float maxHealth = 80f;
    public float currentHealth;
    public SpawnZombies killCount;
    public ClassicPlantStats plantStats;
    public lvl1Settings lvl1;
    public lvl2Settings lvl2;
    public lvl3Settings lvl3;
    public float damageTaken;
    string sceneName;

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
        sceneName = SceneManager.GetActiveScene().name;        
        inCollision = false;
        currentHealth = maxHealth;
        lvl1 = Object.FindFirstObjectByType<lvl1Settings>(); 
        lvl2 = Object.FindFirstObjectByType<lvl2Settings>();
        lvl3 = Object.FindFirstObjectByType<lvl3Settings>();
        if (sceneName == "Level one")
        {
            Speed = lvl1.zombiespeed;
            Debug.Log(Speed);
            damageTaken = lvl1.damage;
            Debug.Log(damageTaken);
        }
        else if (sceneName == "Level two")
        {
            Speed = lvl2.zombiespeed;
            damageTaken = lvl2.damage;
        }
        else if (sceneName == "Level three")
        {
            Speed = lvl3.zombiespeed;
            damageTaken = lvl3.damage;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plant"))
        {
            plantStats = collision.gameObject.GetComponent<ClassicPlantStats>();
            //Debug.Log("collision detected");
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
        currentHealth -= damageTaken;
        //Debug.Log($"{gameObject.name} took 10 damage");
    }
    private void Start()
    {
        killCount = Object.FindFirstObjectByType<SpawnZombies>();
    }
}
