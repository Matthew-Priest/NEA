using UnityEngine;

public class lvl3Settings : MonoBehaviour
{
    public float generationCooldown = 24f; //sun spawning naturally
    public int SpawnCooldown = 9; //zombies
    public int MaxSpawnCount = 30; //zombie
    public float attackCooldown = 4f;
    public float damage = 15f; //look in zombie script to alter
    public float peahealth = 70f;
    public float potatohealth = 25f;
    public float wallnuthealth = 200f;
    public float sunflowerhealth = 40f;
    public bool sunburst = false;
    public float zombiespeed = 0.36f;
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
