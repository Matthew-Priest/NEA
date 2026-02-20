using UnityEngine;

public class lvl2Settings : MonoBehaviour
{
    public float generationCooldown = 20f; //sun spawning naturally
    public int SpawnCooldown = 10; //zombies
    public int MaxSpawnCount = 25; //zombie
    public float attackCooldown = 4f;
    public float damage = 12f; //look in zombie script to alter
    public float peahealth = 70f;
    public float potatohealth = 25f;
    public float wallnuthealth = 200f;
    public float sunflowerhealth = 40f;
    public bool sunburst = false;
    public float zombiespeed = 0.33f;
    public Attributes Attributes;
    void Start()
    {
        Attributes = Object.FindFirstObjectByType<Attributes>();
        if (Attributes.attributeslist.Contains("damageboost")) //boost to plants
        {
            damage = damage * 1.1f;
        }
        if (Attributes.attributeslist.Contains("reducecooldown")) //fire projectile cooldown
        {
            attackCooldown = attackCooldown * 0.9f;
        }
        if (Attributes.attributeslist.Contains("healthboost"))// plant health boost
        {
            peahealth = peahealth * 1.1f;
            wallnuthealth = wallnuthealth * 1.1f;
            sunflowerhealth = sunflowerhealth * 1.1f;
            potatohealth = potatohealth * 1.1f;
        }
        if (Attributes.attributeslist.Contains("sunproduction")) //regular sun production
        {
            generationCooldown = generationCooldown * 0.9f;
        }
        if (Attributes.attributeslist.Contains("sunburst"))// sunflower ability
        {
            sunburst = true;
        }
        if (Attributes.attributeslist.Contains("slowenemies"))
        {
            zombiespeed = zombiespeed * 0.9f;
        }
    }
}
