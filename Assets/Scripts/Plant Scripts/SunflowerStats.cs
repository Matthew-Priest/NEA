using UnityEngine;

public class SunflowerStats : ClassicPlantStats
{
    public float timer = 10;
    public float generationCooldown = 10;
    public GenerateSunViaPlant sunscript;
    private void Start()
    {
        maxHealth = 40;
    }
    private void Update()
    {
        
        timer -= Time.deltaTime;
        if (timer <= 0)
        {           
            sunscript.makeSunViaPlant(transform.position);
            timer = generationCooldown;
        }
    }
}
