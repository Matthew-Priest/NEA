using UnityEngine;

public class Projectile : MonoBehaviour
{
    
    private float Speed = 2f; 
    public Zombie zombieScript;
    void Update()
    {
        transform.Translate(Vector2.right * Speed * Time.deltaTime);
        if (transform.position.x > 16)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zombie"))
        {
            zombieScript = collision.gameObject.GetComponent<Zombie>();
            zombieScript.takeDamage();
            Destroy(gameObject);
            Debug.Log("damage dealt");
        }
    }
}
