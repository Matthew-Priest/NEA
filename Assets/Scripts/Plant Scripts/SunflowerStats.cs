using UnityEngine;
using UnityEngine.SceneManagement;

public class SunflowerStats : ClassicPlantStats
{
    public float regulartimer = 15;
    public float burstTimer = 45;
    public float generationCooldown = 15;
    public GenerateSunViaPlant sunscript;
    public string level;
    private void Start()
    {
        if (sceneName == "Level one")
        {
            maxHealth = lvl1.sunflowerhealth;
            Debug.Log(maxHealth);
        }
        else if (sceneName == "Level two")
        {
            maxHealth = lvl2.sunflowerhealth;           
        }
        else if (sceneName == "Level three")
        {
            maxHealth= lvl3.sunflowerhealth;
        }
        
        currentHealth = maxHealth;
    }
    private void Update()
    {
        burstTimer -= Time.deltaTime;
        regulartimer -= Time.deltaTime;
        switch(sceneName)
        {
            case "Level one":
                if (lvl1.sunburst == true && burstTimer <= 0)
                {
                    sunscript.sunBurst(transform.position);
                    burstTimer = 20;
                }
                break;
            case "Level two":
                if (lvl2.sunburst == true && burstTimer <= 0)
                {
                    sunscript.sunBurst(transform.position);
                    burstTimer = 20;
                }
                break;
            case "Level three":
                if (lvl3.sunburst == true && burstTimer <= 0)
                {
                    sunscript.sunBurst(transform.position);
                    burstTimer = 20;
                }
                break;
        }
        if (regulartimer <= 0)
        {           
            sunscript.makeSunViaPlant(transform.position);
            regulartimer = generationCooldown;
        }
    }
}
