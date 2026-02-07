using UnityEngine;

public class LawnMower : MonoBehaviour
{
    public bool zombiedetected;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Zombie"))
        {
            Destroy(collision.gameObject);
            Debug.Log("zombie killed");
            zombiedetected = true;
        }
        if(transform.position.x > 16)
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if (zombiedetected)
        {
            transform.Translate(Vector2.right * 1 * Time.deltaTime);
        }
    }
    private void Awake()
    {
        zombiedetected = false;
    }
}
