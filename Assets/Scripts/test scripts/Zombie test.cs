using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Zombie_test : MonoBehaviour
{
    public bool inCollision = false;
    public int Speed = 1;

    void Update()
    {
       if(inCollision == false)
        {
            
            transform.Translate(Vector2.left * Speed * Time.deltaTime);
        }
        
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
