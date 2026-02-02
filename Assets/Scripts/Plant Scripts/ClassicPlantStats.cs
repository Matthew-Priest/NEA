using Unity.VisualScripting;
using UnityEngine;

public class ClassicPlantStats : MonoBehaviour
{

    public int maxHealth = 100;
    public float fireCooldown = 2f;
    public int currentHealth;
    public placePlant removePlant;
    private void Awake()
    {
        currentHealth = maxHealth;
        removePlant = Object.FindFirstObjectByType<placePlant>();
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
        removePlant.vectorGameObjectPairs.Remove(transform.position);
    }



}
