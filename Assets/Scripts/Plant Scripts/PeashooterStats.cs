using UnityEngine;

public class PeashooterStats : ClassicPlantStats
{
    public GameObject enemy;
    public GameObject projectile;
    private bool inLane;
    private float timer = 1.425f;
    void Start()
    {
        
        fireCooldown = 4f;
        maxHealth = 60;
    }
    private void Update()
    {
        GameObject[] zombies = GameObject.FindGameObjectsWithTag("Zombie"); //identifies zombies in scene with the tag "zombie" and adds to an array
        inLane = false; //resets detection before end of each frame
        foreach (GameObject z in zombies) //loops through every zombie in scene
        {
            if (Mathf.Abs(z.transform.position.y - transform.position.y) < 0.5f) //calculates difference in height between peashooter & zombie. must be done as checking if 2 floats are equal is bad
            {
                enemy = z; //assigns this enemy as the enemy to shoot at
                inLane = true; //marks that zombie is in this lane
                
                break;//stops checking once a zombie is found in the lane
            }
        }
        if (inLane)
        {
            shoot();
        }
    }
    private void shoot()
    {
        timer -= Time.deltaTime;
        if (timer <= 0 && Mathf.Abs(enemy.transform.position.y - transform.position.y) < 0.1f)
        {
            Instantiate(projectile, gameObject.transform.position, Quaternion.identity);
            timer = fireCooldown;
            Debug.Log("projectile created");
        }
    }
}
