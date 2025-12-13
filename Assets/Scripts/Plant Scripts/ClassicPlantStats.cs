using Unity.VisualScripting;
using UnityEngine;

public class ClassicPlantStats : MonoBehaviour
{

    public int maxHealth = 100;
    public int Damage = 5;
    public double fireCooldown = 2;
    protected int currentHealth;
    private void Awake()
    {
        currentHealth = maxHealth;
    }
    private void Update()
    {
        if (currentHealth <= 0)
        {
            die();
        }
        
        
    }
    public void takeDamage(int damage)
    {
        Debug.Log($"{gameObject.name} took {damage} damage");
        currentHealth -= damage;
    }
    public void die()
    {
        Destroy(gameObject);
    }


}
