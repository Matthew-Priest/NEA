using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Zombie : Entity
{
    private bool inCollision = false;
    public float attackCooldown = 3;
    public float timer = 3;
    public ClassicPlantStats plantStats;
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
    }
    private void Awake()
    {
        inCollision = false;
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
}
