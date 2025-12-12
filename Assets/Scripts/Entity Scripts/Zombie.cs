using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Zombie : Entity
{
    public bool inCollision = false;

    void Update()
    {
       if(inCollision == false)
        {
            
            transform.Translate(Vector2.left * Speed * Time.deltaTime);
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
            Debug.Log("collision detected");
            inCollision = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plant"))
        {
            inCollision = false;
        }
    }
}
