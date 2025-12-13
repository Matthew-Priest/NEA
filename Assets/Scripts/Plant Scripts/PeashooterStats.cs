using UnityEngine;

public class PeashooterStats : ClassicPlantStats
{   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fireCooldown = 1.425;
        maxHealth = 60;
    }
    private void Update()
    {
        //Debug.Log($"health =" +currentHealth);
    }

}
