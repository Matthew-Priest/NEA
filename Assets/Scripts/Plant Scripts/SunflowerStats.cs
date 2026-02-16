using UnityEngine;
using UnityEngine.SceneManagement;

public class SunflowerStats : ClassicPlantStats
{
    public float regulartimer = 10;
    public float burstTimer = 20;
    public float generationCooldown = 10;
    public GenerateSunViaPlant sunscript;
    private void Start()
    {
        if (sceneName == "Level one")
        {
            maxHealth = lvl1.sunflowerhealth;
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
    private void Update()
    {
        burstTimer -= Time.deltaTime;
        regulartimer -= Time.deltaTime;
        if (regulartimer <= 0)
        {           
            sunscript.makeSunViaPlant(transform.position);
            regulartimer = generationCooldown;
        }
        if(lvl1.sunburst == true && burstTimer <= 0)
        {
            sunscript.sunBurst(transform.position);
            burstTimer = 20;    
        }
    }
}
