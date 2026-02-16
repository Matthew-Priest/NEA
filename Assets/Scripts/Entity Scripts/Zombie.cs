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
        if (sceneName == "Level one")
        {
            Speed = lvl1.zombiespeed;
            Debug.Log(Speed);
            damageTaken = lvl1.damage;
            Debug.Log(damageTaken);
        }
        else if (sceneName == "Level two")
        {

        }
        else if (sceneName == "Level three")
        {

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
