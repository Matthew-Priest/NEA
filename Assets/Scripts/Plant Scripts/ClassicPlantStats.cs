using Unity.VisualScripting;
using UnityEngine;

public class ClassicPlantStats : MonoBehaviour
{

    public int maxHealth = 100;
    public int Damage = 5;
    public double fireCooldown = 2;
    protected int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }
    public void takeDamage(int damage)
    {
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
