using UnityEngine;

public class SunflowerStats : ClassicPlantStats
{
    public float timer = 10;
    public int generationCooldown = 10;
    public GenerateSun sunscript;
    private void Start()
    {
        maxHealth = 40;
    }
    private void Update()
    {
        
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = generationCooldown;
            sunscript.makeSunViaPlant(transform.position);
        }
    }
}
