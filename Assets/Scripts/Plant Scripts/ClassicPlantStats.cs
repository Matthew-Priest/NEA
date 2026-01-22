using Unity.VisualScripting;
using UnityEngine;

public class ClassicPlantStats : MonoBehaviour
{

    public int maxHealth = 100;
    public float fireCooldown = 2f;
    public int currentHealth;
    private void Awake()
    {
        currentHealth = maxHealth;
    }
    public void takeDamage(int damage)
    {
        Debug.Log($"{gameObject.name} took {damage} damage");
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            die();
        }
    }
    public void die()
    {
        Destroy(gameObject);
    }


}
