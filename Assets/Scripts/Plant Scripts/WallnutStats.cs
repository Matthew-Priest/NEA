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

        }
        else if (sceneName == "Level three")
        {

        }
        currentHealth = maxHealth;
    }
    
}
