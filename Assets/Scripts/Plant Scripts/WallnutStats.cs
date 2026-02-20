using UnityEngine;

public class WallnutStats : ClassicPlantStats
{
    private void Start()
    {
        if (sceneName == "Level one")
        {
            maxHealth = lvl1.wallnuthealth;
            Debug.Log(maxHealth);
        }
        else if (sceneName == "Level two")
        {
            maxHealth = lvl2.wallnuthealth;
        }
        else if (sceneName == "Level three")
        {
            maxHealth = lvl3.wallnuthealth;
        }
        currentHealth = maxHealth;
    }
    
}
